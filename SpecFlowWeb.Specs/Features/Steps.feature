Feature: Steps

search a web page for a given key word and return back the amount of times it was found

@tag1
Scenario: Scan a Web Page for Number of times a key word appears on that page
	Given Open Google Chrome Page
	When Search for a keyword
	Then Get 10 results of the key word
