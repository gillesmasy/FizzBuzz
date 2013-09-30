Feature: FizzBuzzFeature
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: FizzBuzz.transform()
	Given J'ai une chaîne de caractères de 0 à 10, séparée par un espace
	When je transforme la chaîne
	Then j'obtiens une chaine de caractères 0 1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz

Scenario: FizzBuzz.transform() 2
	Given J'ai une chaîne de caractères de 10 à 20, séparée par un espace
	When je transforme la chaîne
	Then j'obtiens une chaine de caractères Buzz 11 Fizz 13 14 FizzBuzz 16 17 Fizz 19 Buzz 
