Book Parsing
---
### The Problem

1. To write an application that outputs the individual
words that appear in the book, and how many times that
word appears in the text file.
2. The second part is to also output whether the number
of times each word appears is a prime number.

You may ignore punctuation and capitalisation.

### The Challenges
This is my first attempt at writing C#, however, the company
have been kind enough to allow me to write it in Ruby also.

### The Technologies
- Ruby
- RSpec
- Git(Hub)
- C#
- Xamarin Studio
- Mono
- NUnit

### The Instructions
##### Ruby Version
To run the application run `irb`:

```
require "./ruby/lib/book_parser"
=> true
parser = BookParser.new("text.txt")
=> #<BookParser:0x007f80f1d53260 @book="*The Project ...
puts parser.report
Word  |  Number of Words  |  Prime?
The  |  3419  |  False
Project  |  33  |  False
...
```

##### C# Version
```
Load the project and run it within MonoDevelop.
```