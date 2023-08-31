# ROT-13

## Encrypt the message

Write a function that encrypts a text using the ROT-13 method. With ROT-13, each letter of the text to be encrypted is replaced by the letter that is 13 places further back in the alphabet. If this involves going beyond the end of the alphabet, it continues at the beginning:

Example: Hello, World -> URYYB, JBEYQ

e" becomes "R" and "W" becomes "J".
Lower case letters are converted into upper case letters.
Umlauts must be replaced by letter combinations before encryption: "Ö" = "OE", "Ä" = "AE", "Ü" = "UE", "ß" = "SS".
Characters that are not letters are not encrypted.

https://en.wikipedia.org/wiki/ROT13