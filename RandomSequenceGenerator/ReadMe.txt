Q: What is this?
A: This is a small weighted items random sequence generator class.

Q: What does it mean "weighted" item?
A: It's an occurance probability of an item. For example, if we have an items: A, B, C, D with each weight of 1, every item has the same chance to re picked by pRNG.
But if an item B will have weight of 3, this mean that it will have three times higher probability to be picked than the other items. Think of it as instead of items A, B, C, D we have items A, B, B, B, C, D to pick from.
Notice, that this probability is relative, that mean if instead of 1 each item will have weight of 5 or even 1000, the overall probability of every item occurance will be still the same.

Q: How does it work?
A: 
- Create new instance of class using basic constructor. If you want generator to give the same item sequence, use constructor with seed parameter. You can alse change seed with NewSeed().
- Add items by one or from collection using Add(). Make sure the named weight will be larger thann zero.
- Check if item is already presented in generator's collection using Contains(). Find index of certain item using IndexOf();
- Change contained item using SetItem() and it's weight using SetWeight();
- Remove items with Remove(), RemoveAt() and RemoveRande(). Save your time removing all items using Clear().
- Get array of contained items using GetItems() and array of it's weights using GetWeights(). Be aware, that it will be just copy of contained collections.
- At last, call Next() to get a random item from collection or NextSequence() to get a random sequence of items.
- Every time you add or remove items or change it's weight, the generator will have to recalculate cumulative weight array. It will be done at the next call of Next() or NextSequence(), but you can do it manually by calling UpdateWeights().

Q: Is there any potential srew-ups?
A: 
- While getting next item, make sure there is at least one item in collection.
- Make sure all weights are positive.
- Make sure the sum of weights is less than int.Max. Aside the obvious int overflow on getting _weightSum, it's because upper limit of integer Next() have to be exclusive, so it calls as Next(1, _weightSum + 1) which will also lead to int overflow.
- Be aware that in case JumpToItem() have to jump backwards, it will just reinitialize _random with the same seed and blank-call Next() until it will reach given item.

Q: What do you plan to do with it next?
A: 
- Refactor some code.
- Add a few more item collection manipulation methods.
- Add option to choose what type will be used to store item's weight.
- Maybe, will add certain occurance functionality, to make sure certain items will be included into sequence. Although, it could be easilly done outside of the class.