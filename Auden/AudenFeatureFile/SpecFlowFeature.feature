Feature: Loans
	As a customer on Auden Website
	I want to be able to apply for loan


@mytag
Scenario: Customer can make loan application
	Given I navigate to Auden site
	And i assert Minimum loan amount
	And assert maximum loan amount
	When i select loan amount 
	And select weekend as repayment date
	Then assert weekday for repayment 
