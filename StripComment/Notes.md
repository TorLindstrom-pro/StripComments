Done:

- [x] empty string return empty string
- [x] return input if no comment
- [x] only comment returns an empty string
- [x] remove all if string begins with comment
  - "# abc" -> ""
- [x] remove comment at end of string
  - "abc #" -> "abc "
- [x] remove all after comment
  - "abc # abc" -> "abc "

---
Todo:
- [ ] multiple comment symbols
  - "abc # abc\nabc | abc" -> "abc \nabc" 
- [ ] multiline input
  - "abc # abc\nabc" -> "abc \nabc"