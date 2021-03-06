CR_MarkerCloseOnCollect
=======================

This is a very simple plugin (actually there are only 5 lines of code), whose purpose is to close the current file when a marker is collected, but with one single exception, when the marker that's being collected belongs to the same active file.

This can become very handy for those times when you hit F12 to navigate to the definition of some class, defined in a different file, and you just want to go back to the marker but don't want to keep that file open.

Configuration
=============
 * Assign the 'MarkerCloseOnCollect' action to a key. (See [Bind a Key in CodeRush](http://rorybecker.blogspot.com/2009/08/how-to-bind-key-in-coderush.html))

Screenshots
===========

![](./CR_MarkerCloseOnCollect/images/screenshot1.png)

Current file is ExtractHqlNamedQuery.cs

![](./CR_MarkerCloseOnCollect/images/screenshot2.png)

When we hit F12 over LinkedTextHelper class, the file LinkedTextHelper.cs becomes active and a marker is dropped in the previous file

![](./CR_MarkerCloseOnCollect/images/screenshot3.png)

Launching the action 'MarkerCloseOnCollect' (I had it binded to Shift+ESC), the file LinkedTextHelper.cs is closed and the caret is positioned on the previously dropped marker

Original Author: *[Jorge Rowies](http://code.google.com/p/dxcorecommunityplugins/wiki/JorgeRowies)*
