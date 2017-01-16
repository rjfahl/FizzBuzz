function FizzBuzzPlayer() {
    const logFormat = "The FizzBuzz of {input} is {output}."

    return {
         play: play
        // play: (value) => (value % 3 == 0 ? "Fizz" : "") + (value % 5 == 0 ? "Buzz" : "") == "" ? value.toString() : (value % 3 == 0 ? "Fizz" : "") + (value % 5 == 0 ? "Buzz" : "")
    };

    function play(value) {       
        var returnValue = "";
        
        returnValue += value % 3 == 0 ? "Fizz" : "";
        returnValue += value % 5 == 0 ? "Buzz" : "";
        returnValue = returnValue == "" ? value.toString() : returnValue;
        log(value, returnValue);
        return returnValue;
    }

    function log(input, output) {
        console.log(
            logFormat
            .replace('{input}', input)
            .replace('{output}', output)
            )
    }
}