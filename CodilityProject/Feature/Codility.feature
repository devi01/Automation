Feature: Test Search Page
	

Scenario: check query input and search button functionalities
	Given I navigated to the website 'https://codility-frontend-prod.s3.amazonaws.com/media/task_static/qa_csharp_search/862b0faa506b8487c25a3384cfde8af4/static/attachments/reference_page.html'
    Then I can see query input field is displayed
    And I can also see search button is displayed
    And I verify to use an empty query "Provide some query" error message is displaying
    When I querying for "castle"
    Then I verify "No results" message is displaying
    When I querying for "Port Royal"
    Then I verify "Port Royal" message is displaying