import unittest

from .base_page import BasePage
from .login_page import LoginPage
from locators.home_page_locators import HomePageLocators

class HomePage(BasePage):
	def click_login_link(self):
		self.click_button(HomePageLocators.LOGIN_LINK)
		return LoginPage(self.driver)
