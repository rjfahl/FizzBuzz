describe("The FizzBuzz Player", function () {
    var player;
    beforeEach(() => {
        spyOn(console, 'log').and.callFake(function () { });
        player = new FizzBuzzPlayer()
    });
    
    expectResult("1", 1);
    expectResult("Fizz", 3);
    expectResult("Buzz", 5);
    expectResult("FizzBuzz", 15);

    expectLog("The FizzBuzz of 3 is Fizz.", 3);
    expectLog("The FizzBuzz of 5 is Buzz.", 5);
    expectLog("The FizzBuzz of 6 is Fizz.", 6);

    function expectLog(message, input) {
        it("logs a play of " + input, function () {
            player.play(input);
            expect(console.log).toHaveBeenCalledWith(message);
        })
    }

    function expectResult(result, input) {
        describe("given a " + input, function () {
            it("returns " + result, function () {
                var value = player.play(input);
                expect(value).toEqual(result);
            });
        });
    }
});

