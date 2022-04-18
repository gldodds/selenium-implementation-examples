import unittest

from tests.test_login import Tests

login_tests = unittest.TestLoader().loadTestsFromTestCase(Tests)
test_suite = unittest.TestSuite(login_tests)

unittest.TextTestRunner().run(test_suite)
