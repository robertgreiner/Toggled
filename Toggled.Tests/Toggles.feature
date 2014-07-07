Feature: Toggles
	In order to avoid silly mistakes
	As a math idiot
	I want to round up to the nearest integer

@mytag
Scenario: Round all numbers up
	Given I have a numerical value
	When I process the value
	Then the result should round up to the nearest integer
