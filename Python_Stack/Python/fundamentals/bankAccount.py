class User:      # declare a class and give it name User
    def __init__(self, username, email_address):  # now our method has 2 parameters!
        self.name = username                    # and we use the values passed in to set the name attribute
        self.email = email_address              # and the email attribute
        self.account = BankAccount(int_rate=0.02, balance=0)
        self.checking = BankAccount(int_rate=0.0, balance = 0)

    # def display_user_balance(self):
    #     # print("User:", self.name,',', "Balance:", self.account_balance)
    #     print(f"User: {self.name}, Balance: {self.account.display_account_info}")
    #     return self
    def transfer_money(self, other_user, amount):
        self.account.balance -= amount
        other_user.account.balance += amount
        print(self.account.balance, other_user.account.balance)


class BankAccount:
    def __init__(self, int_rate, balance):
        self.intRate = int_rate
        self.balance = balance
    def deposit(self, amount):
        self.balance += amount
        return self
    def withdraw(self, amount):
        self.balance -= amount
        if self.balance < 0:
            print("Insufficient funds: Charging a $5 fee.")
            self.balance -= 5
        return self
    def display_account_info(self):
        print("Balance:", self.balance)
    def yield_interest(self):
        if self.balance > 0:
            self.balance += self.balance * self.intRate
        return self
    def transfer_money(self, other_user, amount):
        self.balance -= amount
        other_user.balance += amount

guido = User("Guido van Rossum", "guido@python.com")
monty = User("Monty Python", "monty@python.com")
coffee = User("Coffee Cup", "coffee@email.com")

print(guido.account.balance)
    

# Account1.deposit(10).deposit(10).deposit(10).withdraw(10).yield_interest().display_account_info()
# Account2.deposit(10).deposit(10).withdraw(5).withdraw(5).withdraw(5).withdraw(5).yield_interest().display_account_info()