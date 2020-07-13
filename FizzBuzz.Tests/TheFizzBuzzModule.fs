module TheFizzBuzzModule

open Xunit

[<Theory>]
[<InlineData(1, "1")>]
[<InlineData(2, "2")>]
[<InlineData(3, "Fizz")>]
[<InlineData(5, "Buzz")>]
[<InlineData(6, "Fizz")>]
[<InlineData(10, "Buzz")>]
[<InlineData(15, "FizzBuzz")>]
[<InlineData(30, "FizzBuzz")>]
[<InlineData(43, "Trill")>]
[<InlineData(86, "Trill")>]
let ``Given`` number expects =
    Assert.Equal(expects, FizzBuzz.Play number)