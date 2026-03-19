Done:

- [x] empty string return empty string
- [x] return input if no comment
- [x] only comment returns an empty string
- [x] remove all if string begins with comment
  - "# abc" -> ""

---
Todo:

- [ ] remove comment at end of string
  - "abc #" -> "abc "
- [ ] remove all after comment
  - "abc # abc" -> "abc "
- [ ] multiline input
  - "abc # abc\nabc" -> "abc \nabc"