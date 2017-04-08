using System;
using System.Collections.Generic;
using System.Text;

namespace RandomSequenceGenerator
{
  public class RandomSequenceGenerator<T>
  {
    private Random _random; //pRNG
    private int _seed; //seed with which pRNG was initiated
    private int _pass; //amount of random numbers which was generated since the last pRND initialization

    private List<T> _items; //items
    private List<int> _weights; //item's weights (should no be less than 1)
    private int[] _weightsCumulative; //array of cululative item's weights, used for binary search, generated before Next and NextSequence if _updateCumulativeWeights if TRUE
    private int _weightSum; //cachied sum of all item's weights
    private bool _updateCumulativeWeights; //flag to update cumulative weights array, should be set to TRUE every time list of items or some if it's weights are changed

    public int Seed
    {
      get { return _seed; }
    }

    public int Pass
    {
      get { return _pass; }
    }

    public int ItemsCount
    {
      get { return _items.Count; }
    }

    public RandomSequenceGenerator()
    {
      NewSeed();

      _items = new List<T>();
      _weights = new List<int>();
      _weightsCumulative = new int[0];
      _weightSum = 0;
      _updateCumulativeWeights = false;
    }

    #region [pRNG manipulation]

    public void NewSeed(int seed)
    {
      _seed = seed;
      _pass = 0;
      _random = new Random(seed);
    }

    public void NewSeed()
    {
      NewSeed((int)DateTime.Now.ToBinary()); //TODO: should I change (int)DateTime.Now.ToBinary() to something better?
    }

    /// <summary>
    /// Jump to given item of random sequence.
    /// </summary>
    public void JumpToItem(int index)
    {
      if (index < _pass)
      {
        NewSeed(_seed);
      }
      
      SkipItems(index - _pass);
    }

    /// <summary>
    /// Skip given number of items of random sequence.
    /// </summary>
    public void SkipItems(int indexesToPass)
    {
      for (int i = _pass; i < indexesToPass; i++)
        Next();

      _pass += indexesToPass;
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

    #endregion

    #region[pRNG sequence wrappers]

    public T Next()
    {
      if (_items.Count < 1)
      {
        throw new Exception("There is no items to select from!");
      }

      if (_updateCumulativeWeights)
      {
        UpdateWeight();
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
        UpdateWeight();
      }

      T[] result = new T[length];

      for (int i = 0; i < length; i++)
      {
        result[i] = InnerNext();
      }

      return result;
    }

    #endregion

    #region [inner methods]

    private T InnerNext()
    {
      int weight = _random.Next(1, _weightSum + 1);

      int index = Array.BinarySearch(_weightsCumulative, weight);

      if (index < 0)
      {
        index = (index * -1) - 1;
      }

      _pass++;

      return _items[index];
    }

    public void UpdateWeight()
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
  }
}
