Feature: Balance
	In order to avoid silly mistakes
	As a gambling costumer
	I want to be know my actual balance
	
@mytag
Scenario: Check Balance
	Given I am in a full loaded application
	When I logged into the app
	Then the balance should be displayed
