## Overview

A couple of fairly equivalent login tests in C# & Python against the default [English] Wikipedia page.

## Scenario

1. Navigate to Wikipedia, click the **Login** link in the upper-right corner, provide invalid credentials for the login form, & submit the page. Validate that the error notification text matches the expected results.

## .NET Implementation

* Broken down as page objects to help decouple interacting directly with elements & executing behaviors in the actual test.
* Locators are included on pages in-line since this is supported.
* Reusable data for tests defined in code, but could be updated to dynamically read from an external JSON, YAML, etc.

## Python [3] Implementation

* Similarly broken down as page objects, but more granular to help separate locators vs. page interactions.
* Same note regarding reusable data—could be updated to dynamically read from an external JSON, YAML, etc.

With `chromedriver` already added to PATH, can install required library (Selenium) with `pip install -r requirements`, then execute the default suite (one case) with `python -m suites.login_suite`.