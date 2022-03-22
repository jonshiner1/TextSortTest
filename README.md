# PROJECT NAME - TextABCSort

## Acceptance Test

as a paragraph word analyser
* For a given Text paragraph, I want to read through the paragraph where the words in the paragraph has been reordered and formatted as follows
    *	Results should be ordered Alphabetically First, (Zerbra Abba) becomes (Abba Zebra)
    *	Results should **THEN** be ordered from upper case to lower case. Note point 1 takes preference. (aBba Abba) becomes (Abba aBba)
    * Remove all (.,;') chars. (aBba, Abba) becomes (Abba aBba)
    *	Do not remove duplicate words
* so that I can easily read though the words alphabetically

## Notes
* The acceptance test is most important. Other notes are of secondary importance.
* if needed additional unit tests may be added
* insure you are happy with the project structure
* take into account we may want to swap console logger with event logger in future
* although this is a simple test, please complete the code as you would for a production release
