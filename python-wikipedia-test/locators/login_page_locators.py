from selenium.webdriver.common.by import By

class LoginPageLocators():
	LOGIN_EMAIL_FIELD = (By.ID, 'wpName1')
	LOGIN_PASSWORD_FIELD = (By.ID, 'wpPassword1')
	LOGIN_BUTTON = (By.ID, 'wpLoginAttempt')
	RESULT_NOTIFICATION = (By.CLASS_NAME, 'mw-message-box-error');
