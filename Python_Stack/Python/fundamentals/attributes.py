class User:      # declare a class and give it name User
    def __init__(self,username, email_address):  # now our method has 2 parameters!
        self.name = username                    # and we use the values passed in to set the name attribute
        self.email = email_address              # and the email attribute
        self.account_balance = 0                # the account balance is set to $0, so no need for a third parameter
    #adding the deposit method
    def make_deposit(self, amount):         # takes an argument that is the amount of the deposit
        self.account_balance += amount      # the specific user's account increases by the amount of the value received
        return self
    def make_withdrawal(self, amount):
        self.account_balance -= amount
        return self
    def display_user_balance(self):
        # print("User:", self.name,',', "Balance:", self.account_balance)
        print(f"User: {self.name}, Balance: {self.account_balance}")
        return self
    def transfer_money(self, other_user, amount):
        self.account_balance -= amount
        other_user.account_balance += amount
        print(self.account_balance, other_user.account_balance)



guido = User("Guido van Rossum", "guido@python.com")
monty = User("Monty Python", "monty@python.com")
coffee = User("Coffee Cup", "coffee@email.com")



guido.make_deposit(100).make_deposit(200).make_deposit(50).make_withdrawal(200).display_user_balance()

monty.make_deposit(50).make_deposit(100).make_withdrawal(25).make_withdrawal(25).display_user_balance()

coffee.make_deposit(10).make_withdrawal(2).make_withdrawal(2).make_withdrawal(2).display_user_balance()

guido.transfer_money(coffee, 100)

# print(monty.account_balance)
# print(guido.name)
# print(monty.name)
# print(coffee.name)