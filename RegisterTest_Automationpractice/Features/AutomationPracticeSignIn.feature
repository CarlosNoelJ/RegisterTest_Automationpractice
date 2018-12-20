Feature: AutomationPracticeSignIn
	As a user
	I want to sign in
	So I see my profile

Background: 
	Given I am on the Sign in site

@web
Scenario: Should see my profile 
	When I complete the fields 
	Then I can see the account section on the top
