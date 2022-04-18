import unittest
from selenium import webdriver

from .base_test import BaseTest
from data.login_test_data import LoginPageTestData as TestData
from pages.home_page import HomePage
from pages.login_page import LoginPage

class Tests(BaseTest):
	def test_invalid_login(self):
		home_page = HomePage(self.driver)

		login_page = home_page.click_login_link()
		login_page.login(TestData.INVALID_USERNAME, TestData.INVALID_PASSWORD)
		login_page.assert_notification_text(TestData.INVALID_USER_ERROR_TEXT)
