# _Word Counter_

#### _A console application that checks how frequently a word appears in a sentence, Created 2/15/2019_

#### By _**Yulia Shidlovskaya**_

## Description

_A program that allows a user to input a single word and a phrase. Then it checks how many times the word appears in the sentence.

The program uses the following specifications:_

* _The program receives a word and a sentence from a user._
* _The program recognizes upper case and lower case letter as the same letter._
* _The program returns 0, if the word input is empty, nothing to search for._
  - Example Input Word: ""
  - Example Input Sentence: "I'm walking to the cathedral."
  - Example Output: 0  
* _The program returns 0, if the sentence input is empty, nothing to search in._
  - Example Input Word: "cat"
  - Example Input Sentence: ""
  - Example Output: 0  
* _The program returns 1, if the sentence matches the word._
  - Example Input Word: "cat"
  - Example Input Sentence: "cat"
  - Example Output: 1  
* _The program returns 1, if the sentence starts with the word, and one of punctuation marks or space is following the word._
  - Example Input Word: "cat"
  - Example Input Sentence: "Cat is fat"    
  - Example Output: 1  
* _The program returns 1, if the sentence starts with the word, and one of punctuation marks is following the word._
  - Example Input Word: "cat"
  - Example Input Sentence: "Cat? It is fat"    
  - Example Output: 1  
* _The program returns 1, if the word appears once with spaces before and after._
  - Example Input Word: "cat"
  - Example Input Sentence: "I have a cat and a dog."  
  - Example Output: 1  
* _The program returns 1, if the word appears once with a space before and one of punctuation marks .,:;!?'" after._
  - Example Input Word: "cat"
  - Example Input Sentence: "Do you have a cat?"
  - Example Output: 1
* _The program returns 2, if the word appears twice with spaces before and after._
  - Example Input Word: "cat"
  - Example Input Sentence: "I have a cat and another cat."  
  - Example Output: 2    
* _The program returns 1, if the word appears once with "(" before and one of punctuation marks .,:;!?'") after._
  - Example Input Word: "cat"
  - Example Input Sentence: "I have a pet (cat)."  
  - Example Output: 1  
* _The program returns 1, if the word appears once with space before, and it is the last word in the sentence._
  - Example Input Word: "cat"
  - Example Input Sentence: "I have a cat"    
  - Example Output: 1  
* _The program returns 0, if the sentence contains the word with a space before and non-alphabetic symbol after excluding punctuation marks .,:;!?'"._
  - Example Input Word: "cat"
  - Example Input Sentence: "cat1 = new Cat();"
  - Example Output: 0
* _The program returns 0, if another word starts with the word._
  - Example Input Word: "cat"
  - Example Input Sentence: "I'm walking to the cathedral."
  - Example Output: 0    

* _The program returns 0, if the word is a part of another word._
  - Example Input Word: "cat"
  - Example Input Sentence: "scatter"
  - Example Output: 0    

## Setup/Installation Requirements

* _Please visit the GitHub repository for this project at "https://github.com/sjullieb/csharp-word-counter"_
* _Clone repository or download to desktop_

## Known Bugs

_No known bugs_

## Support and contact details

_If you run into any issues or have questions, ideas or concerns. Please email me at sjullieb@gmail.com_

## Technologies Used

* _C#_

### License

*MIT*

Copyright (c) 2019 **_Yulia Shidlovskaya_**
