

class Deck:

    def __init__(self):
        self.suits = []
        self.number = []




    def do_something(self):
        self.suits = []


def main():
    cards = Deck()

    print(f", ".join(cards.suits))
    cards.suits = ["spades", "clubs", "hearts", "diamonds"]
    print(f", ".join(cards.suits))
    cards.do_something()
    print(f", ".join(cards.suits))

if __name__ == "__main__":
    main()