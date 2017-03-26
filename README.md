# Cataclysm Modder
C# Winforms application for editing JSON files from the game [Cataclysm: Dark Days Ahead](http://www.cataclysmdda.com/).

No warranty of usability or fitness for any purpose is given.

**MAKE SURE YOU ARE USING THE RIGHT VERSION OF CATACLYSM!**

You'll need the Microsoft .NET Redistributable 4.0 to run this version: http://www.microsoft.com/en-us/download/details.aspx?id=17851

# How to use this software

* Back up the 'raw' folder that contains the game JSONs (it's in [Cataclysm Root]/data).
* Run CataclysmModder.exe
* Go to File->Open
* Select the 'raw' folder mentioned above

Now the dropdown box in the top-left corner of the program contains all the JSON data files that define Cataclysm's content, though the program only supports editing "item_groups.json" and the "item/" files for now.

Once you select a file from this box, the file's contents are loaded into the "Entries" box under it, and if the file can be edited, the editing area appears to the right.

# Usability Tips
You can type in the "Quicksearch" bar at the top right to search the entries list by name or id. Press Enter to scan through the search results.

You can use Ctrl+Up and Ctrl+Down at any time to navigate up and down the entries list.

In list boxes with a lot of items, you can press a key on the keyboard to scroll through items starting with that letter.

Whenever you select a field in the editor, a short helpful description of what that field means is shown in the very bottom-right.

# Contribute
Cataclysm Modder is licensed under the Creative Commons Attribution ShareAlike 3.0 license. The code and content of the game is free to use, modify, and redistribute for any purpose whatsoever. See http://creativecommons.org/licenses/by-sa/3.0/ for details. Some code distributed with the project is not part of the project and is released under different software licenses, the files covered by different software licenses have their own license notices.