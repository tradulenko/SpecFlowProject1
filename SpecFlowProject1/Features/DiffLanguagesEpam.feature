@LangEpam
Feature: Different languages in epam.com

 Background: 
	Given I open 'epam.com' home page
@TC001
Scenario Outline: TC001 Verifying possibility of switching languages
	When I choose '<language>' language
	Then I see '<menuCompany>' menu

Examples: 
	| language   | menuCompany  |
	| Українська | ПРО КОМПАНІЮ |
	| Polski     | O NAS        |


@TC002
Scenario: TC002 Verifying required filds in Contact page
	When I submit empty contact form
	Then I see 4 field are required
