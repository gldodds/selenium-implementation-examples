## Overview

A couple of fairly equivalent login tests in C# & Python against the default [English] Wikipedia page.

## Folder Structure

```
DotNetWikipediaTest/ (C# example)
├─ DotNetWikipediaTest/
│  ├─ Data/
│  │  ├─ LoginData.cs
│  │     * Test data used for login test case(s).
│  ├─ PageObjects/
│  │  ├─ HomePage.cs
│  │  │  * Home page element locators & function definitions.
│  │  ├─ LoginPage.cs
│  │     * Login page element locators & function definitions.
│  ├─ DotNetWikipediaTest.csproj
│  ├─ Tests.cs
│     * Invalid login test case. 
├─ DotNetWikipediaTest.sln
python-wikipedia-test/ (Python example)
├─ data/
│  ├─ login_test_data.py
│        * Test data used for login test case(s).
├─ locators/
│  ├─ home_page_locators.py
│  │  * Home page element locator definitions.
│  ├─ login_page_locators.py
│     * Login page element locator definitions.
├─ pages/
│  ├─ base_page.py
│  │  * Parent class for pages to inherit from.
│  ├─ home_page.py
│  │  * Home page function definitions.
│  ├─ login_page.py
│     * Login page function definitions.
├─ suites/
│  ├─ login_suite.py
│     * Suite definition when running from CLI.
├─ tests/
│  ├─ base_test.py
│  │  * Parent class for tests to inherit from.
│  ├─ test_login.py
│     * Invalid login test case.
├─ requirements.txt
```

## Scenario

1. Navigate to Wikipedia, click the **Login** link in the upper-right corner, provide invalid credentials for the login form, & submit the page. Validate that the error notification text matches the expected results.

## .NET Implementation

* Broken down as page objects to help decouple interacting directly with elements & executing behaviors in the actual test.
* Locators are included on pages in-line since this is supported.
* Reusable data for tests defined in code, but could be updated to dynamically read from an external JSON, YAML, etc.

## Python [3] Implementation

* Similarly broken down as page objects, but more granular to help separate locators vs. page interactions.
* Same note regarding reusable data—could be updated to dynamically read from an external JSON, YAML, etc.

With [chromedriver](https://chromedriver.chromium.org/downloads) already added to PATH, can install required library (Selenium) with `pip install -r requirements`, then execute the default suite (one case) with `python -m suites.login_suite`.