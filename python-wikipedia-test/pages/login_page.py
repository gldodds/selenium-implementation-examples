import unittest

from .base_page import BasePage
from locators.login_page_locators import LoginPageLocators

class LoginPage(BasePage):
	def set_credentials(self, email, password):
		self.set_field(LoginPageLocators.LOGIN_EMAIL_FIELD, email)
		self.set_field(LoginPageLocators.LOGIN_PASSWORD_FIELD, password)

	def click_login_button(self):
		self.click_button(LoginPageLocators.LOGIN_BUTTON)

	def assert_notification_text(self, text):
		self.assert_text_match(LoginPageLocators.RESULT_NOTIFICATION, text)

	def login(self, email, password):
		self.set_credentials(email, password)
		self.click_login_button()
