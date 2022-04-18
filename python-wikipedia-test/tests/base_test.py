import unittest
from selenium import webdriver

class BaseTest(unittest.TestCase):
	def setUp(self):
		options = webdriver.ChromeOptions()
		options.add_argument('--start-maximized')

		self.driver = webdriver.Chrome(options=options)
		self.driver.get("https://en.wikipedia.org")

	def tearDown(self):
		self.driver.quit()
