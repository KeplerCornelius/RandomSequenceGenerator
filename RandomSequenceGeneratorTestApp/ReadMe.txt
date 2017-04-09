Q: What is this?
A: This is a small app to test weighted items random sequence generator I wrote.

Q: How does it work?
A: 
- The "Length" is the length of sequence to be generated.
- The "Start from" will set first index of generated sequence. For example, if we have a certain seed which gives us sequence 3, 1, 4, 1, 5, 9... we can start from the third index, and the sequence will be 4, 1, 5, 9...
- The "Seed" is the seed with which pRNG will be initialized. If this field is empty, every generation the seed will be picked anew.
The "X" button will clear the field. The "?" button will put a random number from 1 to 99999 in the field.
- On the "Simple" tab you can choose arrays of characters to be included in items to choose from.
- On the "Advanced" tab you can input a special sequences and set it's weights. You can put a several strings at once by typing them into upper text field. Then, set a separator, set the initial weight for them and press "Parse" button.
If you don't set the separator, the whole string will be added as separate item. Select items in table and you can change their strings and weights in fields just below the table. If you don't want some item to be in item list, select it and press "Del" button.
You can clear the whole advanced item list by pressing "Clear list" button.
- The "Copy" button will copy generated sequence in the clipboard.

Q: Is there any potential srew-ups?
A: 
- Notice that the seed used to initiate the pRNG is a GetHash() product of text in Seed field. And you can't use zero-length string as seed source, because if there is no text in seed field, the seed will be always a random.
- Be aware that the sequence of latin/cyrillic characters in upper or lower case will be different from sequence in mixed case, as for the last generator actually have to choose from upper and lower characters arrays merged together.
- Make sure the sum of weights is less than int.Max. Aside the obvious int overflow on getting _weightSum, it's because upper limit of integer Next() have to be exclusive, so it calls as Next(1, _weightSum + 1) which will also lead to int overflow.
- Be aware that in case JumpToItem() have to jump backwards, it will just rest _random and blank-call Next() until it will reach given item.

Q: What do you plan to do with it next?
A: 
- I don't know actually, it was made just as the test app.