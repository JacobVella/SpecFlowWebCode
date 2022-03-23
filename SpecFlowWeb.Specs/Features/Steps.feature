Feature: Steps

search a web page for a given key word and return back the amount of times it was found

@tag1
Scenario: Scan a Web Page for Number of times a key word appears on that page
	Given Open Google Chrome Page
	And the search bar is selected
	And the keyword is entered
	And enter is pressed
	When key word is found on the page
	Then check if key word was found 10 times
