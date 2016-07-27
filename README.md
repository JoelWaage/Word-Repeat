# **Word Repeat**

#### _Finds instances of a word in a longer sentence._

#### By _**Joel Waage**_

## Description

_This application takes user inputs of a word and a sentence,  and determines the number of times the word appears in the sentence ._

## Setup/Installation Requirements

_TBD_

## Specifications
| Behavior | Input Example | Output Example |
| ------------- |-------------|:-----:|
|User inputs the same single letter in the WORD and SENTENCE forms |WORD: a // SENT: a  | 1 |
|User inputs the same word in the WORD and SENTENCE forms  |WORD: ab // SENT: ab | 1 |
|User inputs a single letter in the WORD form and a different letter in the SENTENCE form |WORD: a // SENT: b | 0 |
|User inputs a word in the WORD form and a different string in the SENTENCE form |WORD: ab // SENT: cd | 0 |
|User inputs a letter in the WORD form and that letter and a different letter in the SENTENCE form |WORD: a // SENT:  a b | 1 |
|User inputs a WORD in the word form and that word and a different word in the SENTENCE form |WORD: ab // SENT:  ab cd | 1 |
|User inputs a letter in the WORD form and the same letter twice in the SENTENCE form  |WORD: a // SENT: a a | 2 |
|User inputs a word in the WORD form and the same word twice in the SENTENCE form  |WORD: ab // SENT: ab ab  | 2 |
|User inputs a letter in the WORD form and that letter multiple times as well as other letters in the SENTENCE form |WORD: a // SENT: a b c a e c a | 3|
|User inputs a word in the WORD form and that word multiple times as well as other word in the SENTENCE form |WORD: ab // SENT: ab tr ab cd ab| 3|
|User inputs the same letter in WORD and SENTENCE, but with different cases |WORD: a // SENT: A| 1 |
|User inputs the same letter in WORD and SENTENCE, but with punctuation in SENTENCE|WORD: a // SENT: a?| 1 |

## Known Bugs

_None known._

## Support and contact details

_Contact TBD_

## Technologies Used

_C#, Xunit_

### License

*MIT License

*Copyright (c) [2016] Joel Waage*
