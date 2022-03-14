This is a brief guide using excerpts from the lectures and the Rubin book to help guide a team through the scrum process. It is not meant to be comprehensive, but, it does sort of summarize the material presented in the book and the process in general. It also loosely represents our teams plan for continuing on with the project for the semester.
Scrum Abbreviated
	Scrum Roles
		Product Owner – tells us what they want built
		ScrumMaster – guides the team through the process
		Development Team – builds product
	Scrum Activities and Artifacts
		Product Backlog – list of stuff to do
		Sprints – timed period of development where no changes can be made
		Sprint Planning – plan for a sprint, define the goal
		Sprint Execution – get to work implementing the plan
		Daily Scrum – “daily” <15 minute meeting to discuss progress on sprint
		Done – end of sprint deliverable product
		Sprint Review – go over the product with everyone and make adjustments
		Sprint Retrospective – check the process, how did the process work? Did we try to do to much or not enough? This is a process overview
Sprints
Sprints should last no more than a few weeks
Once the goal of the sprint has been set, there can be no changes that change the goal of the sprint
Sprints should be clearly defined both in scope and duration
Before beginning a sprint, a clear definition of done needs to be established for each item.
For all items to be done, review the done checklist on page 74 of the book
Requirements and User Stories
Use Gherkin Notation and user stories to capture the details of the project
User Story Format:( Borrowed from Dr. Babb format for assignment 4)
Feature: Brief Title
	As a: Role
	I want a: feature
	So that I can get: Expected Benefit
Additional Background Info
	Optional Description
Acceptance criteria
Scenario: Brief Title
	Optional Description
	Given: Describe prerequisites
When: Describe interaction or state change
Then: Describe intended results with “should
To be fully defined, a user story must meet the INVEST criteria
	I = Independent – minimize dependencies as much as possible
	N = Negotiable – not hard set, should balance wants with needs
	V = Valuable – customer wants the feature
	E = Estimatable – if you do not know the size, you are not ready to implement
	S = Sized Appropriately – keep them small, so we can finish by the end of the sprint
	T = Testable – if we can’t test it, it is not well developed
To help ensure the User Stories are correct and to elicit more information, rephrase the story back to the product owner and encourage their feedback
Two ways to develop user stories
	User Story Writing Workshop
Story Mapping
Product Backlog Items(PBI)
	Features
	Defects
	Technical Work
	Knowledge Acquisition
Change
Characteristics
	Detailed Appropriately
	Emergent
	Estimated
	Prioritized
The PBI must be groomed
	Grooming Process
		Creating and Refining
		Estimating PBI’s
		Prioritizing
	Grooming is performed by all the stakeholders as new information emerges
	Definition of ready from the Rubin book
		Business value is clearly articulated
		Details are sufficiently understood, to make an informed decision whether it can be completed
		Dependencies are identified and no external dependencies would block from being implemented
Prioritize the list into must-haves, nice to have, and won’t have for each release
Do the must haves and try to get to the nice to haves if possible
Estimation and Velocity
Initially, the team will use estimate as a team to estimate how long it will take to do pbi’s. 
	A transition to Planning poker pg 129 Rubin may be necessary as we progress
We will use Story points to estimate the PBI size
Since, we have no historical data on team velocity, initially we will take a guestimate on the first sprint and go from there to more precisely measure velocity
Technical Debt
Types
	Bad Design
	Defects
	Insufficient test coverage
	Excessive manual testing
	Poor Integration and release management
How to identify
	Assembly errors
	Feedback from Professor
	Erroneous output
	Having to “make things work” for a deadline, and not readdressing the issue
	No testing process used
How to Service Technical debt
	Use Strong definition of Done
	Use good coding practices to begin with
	Heavily use testing to code
	Use thorough code reviews
	Make note of intended technical debt, and make sure it is addressed in future iterations
	Fix the error as you work on other things if possible
Scrum Planning Principles
	Don’t assume we can get the plans right upfront
	Up-front planning should be helpful without being excessive
	Keep planning options open until the last responsible moment
	Focus more on adapting and replanning than on conforming to a plan
	Correctly manage the planning inventory
	Favor small and more frequent releases
	Plan to learn fast and pivot when necessary
SOLID Principles
	SRP – Single Responsibility Principle – a module should be responsible to one, and only one, actor
	OCP – The Open-Closed Principle – design the software in a way that to make a change you add code and not modify existing code
	LSP – The Liskov Substitution Principle – to make software reuseable, build them in a consistent way so that they can be substituted one for another
ISP – The Interface Segregation Principle – don’t depend on things you don’t use(referring to depencies)
DIP – The Dependency Inversion Principle – code that implements high level policy should not depend on low level details
The Clean Architecture



