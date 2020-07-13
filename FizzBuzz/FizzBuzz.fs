module FizzBuzz

let multipleOf factor number = 
    number % factor = 0

let wordFor number factor word =
    if number |> multipleOf factor then word else ""

let Play number =
    let result = (wordFor number 3 "Fizz") + (wordFor number 5 "Buzz") + (wordFor number 43 "Trill")
    if result = "" then number.ToString() else result