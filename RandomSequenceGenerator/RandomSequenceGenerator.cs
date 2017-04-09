using System;
using System.Collections.Generic;
using System.Text;

namespace RandomSequenceGenerator
{
  /// <summary>
  /// Enhanced Random which carry it's seed and amount of generated random numbers
  /// </summary>
  public class RandomE : Random
  {
    private int _seed;
    public int _pass;

    /// <summary>
    /// Seed with which pRNG was initiated
    /// </summary>
    public int Seed
    {
      get { return _seed; }
    }

    /// <summary>
    /// Amount of random numbers which was generated since the last pRND initialization
    /// </summary>
    public int Pass
    {
      get { return _pass; }
    }

    public RandomE(int Seed) : base(Seed)
    {
      _seed = Seed;
      _pass = 0;
    }

    public RandomE() : this(Environment.TickCount){ } //that's how they took unique int in original Random class

    public override int Next()
    {
      _pass++;
      return base.Next();
    }

    public override int Next(int maxValue)
    {
      _pass++;
      return base.Next(maxValue);
    }

    public override int Next(int minValue, int maxValue)
    {
      _pass++;
      return base.Next(minValue, maxValue);
    }

    public override void NextBytes(byte[] buffer)
    {
      if (buffer != null)
      {
        _pass += buffer.Length;
      }

      base.NextBytes(buffer);
    }

    public override double NextDouble()
    {
      _pass++;
      return base.NextDouble();
    }
  }

  public class RandomSequenceGenerator<T>
  {
    private RandomE _random; //enhanced Random which carry it's seed and amount of generated random numbers

    private List<T> _items; //items
    private List<int> _weights; //item's weights (each one should be larger than 0)
    private int[] _weightsCumulative; //array of cululative item's weights, used for binary search, generated before Next and NextSequence if _updateCumulativeWeights if TRUE
    private int _weightSum; //cachied sum of all item's weights
    private bool _updateCumulativeWeights; //flag to update cumulative weights array, should be set to TRUE every time list of items or some if it's weights are changed

    /// <summary>
    /// Seed with which pRNG was initiated
    /// </summary>
    public int Seed
    {
      get { return _random.Seed; }
    }

    /// <summary>
    /// Amount of random numbers which was generated since the last pRND initialization
    /// </summary>
    public int Pass
    {
      get { return _random.Pass; }
    }

    public int ItemsCount
    {
      get { return _items.Count; }
    }

    public RandomSequenceGenerator(int seed)
    {
      NewSeed(seed);
      Initiate();
    }

    public RandomSequenceGenerator()
    {
      NewSeed();
      Initiate();
    }

    private void Initiate()
    {
      _items = new List<T>();
      _weights = new List<int>();
      _weightsCumulative = new int[0];
      _weightSum = 0;
      _updateCumulativeWeights = false;
    }

    #region [pRNG manipulation]

    public void NewSeed()
    {
      _random = new RandomE();
    }

    public void NewSeed(int seed)
    {
      _random = new RandomE(seed);
    }

    /// <summary>
    /// Jump to given item of random sequence.
    /// </summary>
    public void JumpToItem(int index)
    {
      if (index < _random.Pass)
      {
        NewSeed(_random.Seed);
      }
      
      SkipItems(index - _random.Pass);
    }

    /// <summary>
    /// Skip given number of items of random sequence.
    /// </summary>
    public void SkipItems(int indexesToPass)
    {
      for (int i = _random.Pass; i < indexesToPass; i++)
        Next();
    }

    #endregion

    #region [collection methods]

    public void Add(T item, int weight = 1)
    {
      if (weight < 1)
      {
        throw new ArgumentException("Weight can't be 0 or negative!");
      }

      _items.Add(item);
      _weights.Add(weight);
      _updateCumulativeWeights = true;
    }

    public void Add(IEnumerable<T> items, int weight = 1)
    {
      foreach (T item in items)
      {
        Add(item, weight);
      }
    }

    public void RemoveAt(int index)
    {
      _items.RemoveAt(index);
      _weights.RemoveAt(index);

      _updateCumulativeWeights = true;
    }

    public void Remove(T item)
    {
      int index = _items.IndexOf(item);

      if (index > -1)
      {
        RemoveAt(index);
      }
    }

    public void RemoveRange(int startIndex, int count)
    {
      _items.RemoveRange(startIndex, count);
      _weights.RemoveRange(startIndex, count);

      _updateCumulativeWeights = true;
    }

    public void Clear()
    {
      _items.Clear();
      _weights.Clear();

      _updateCumulativeWeights = true;
    }

    public T[] GetItems()
    {
      return _items.ToArray();
    }

    public int[] GetWeights()
    {
      return _weights.ToArray();
    }

    public bool Contains(T item)
    {
      return _items.Contains(item);
    }

    public int IndexOf(T item)
    {
      return _items.IndexOf(item);
    }

    public int IndexOf(T item, int index)
    {
      return _items.IndexOf(item, index);
    }

    public int IndexOf(T item, int index, int count)
    {
      return _items.IndexOf(item, index, count);
    }

    public void SetItem(int index, T item)
    {
      _items[index] = item;
    }

    public void SetItem(T item, T replace)
    {
      int index = _items.IndexOf(item);

      if (index > -1)
      {
        SetItem(index, replace);
      }
    }

    public void SetWeight(int index, int weight)
    {
      if (weight < 1)
      {
        throw new ArgumentException("Weight can't be 0 or negative!");
      }

      _weights[index] = weight;

      _updateCumulativeWeights = true;
    }

    public void SetWeight(T item, int weight)
    {
      int index = _items.IndexOf(item);

      if (index > -1)
      {
        SetWeight(index, weight);
      }
    }

    public void UpdateWeights()
    {
      _weightsCumulative = new int[_weights.Count];

      int weightCurrent = 0;

      try
      {
        checked
        {
          for (int i = 0; i < _weights.Count; i++)
          {
            weightCurrent += _weights[i];
            _weightsCumulative[i] = weightCurrent;
          }

          _weightSum = weightCurrent;
        }
      }
      catch
      {
        throw new OverflowException("The sum of weights is too large!");
      }

      if (weightCurrent == int.MaxValue)
      {
        throw new OverflowException("The sum of weights is too large!");
      }

      _updateCumulativeWeights = false;
    }

    #endregion

    #region[pRNG methods]

    public T Next()
    {
      if (_items.Count < 1)
      {
        throw new Exception("There is no items to select from!");
      }

      if (_updateCumulativeWeights)
      {
        UpdateWeights();
      }

      return InnerNext();
    }

    public T[] NextSequence(int length)
    {
      if (_items.Count < 1)
      {
        throw new Exception("There is no items to select from!");
      }

      if (_updateCumulativeWeights)
      {
        UpdateWeights();
      }

      T[] result = new T[length];

      for (int i = 0; i < length; i++)
      {
        result[i] = InnerNext();
      }

      return result;
    }

    private T InnerNext()
    {
      int weight = _random.Next(1, _weightSum + 1);

      int index = Array.BinarySearch(_weightsCumulative, weight);

      if (index < 0)
      {
        index = (index * -1) - 1;
      }

      return _items[index];
    }

    #endregion
  }
}
