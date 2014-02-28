from random import choice

while(True):
        print("\n" + 'Hangman Game:' + "\n")
        hangmanVar = {
                        0: '------' + "\n|    |" + "\n|" + "\n|" + "\n|" + "\n|" + "\n|" +"\n----------",
                        1: '------' + "\n|    |" + "\n|    0" + "\n|" + "\n|" + "\n|" + "\n|" +"\n----------",
                        2: '------' + "\n|    |" + "\n|    0" + "\n|   -+-" + "\n|" + "\n|" + "\n|" +"\n----------",
                        3: '------' + "\n|    |" + "\n|    0" + "\n|  /-+-" + "\n|" + "\n|" + "\n|" +"\n----------",
                        4: '------' + "\n|    |" + "\n|    0" + "\n|  /-+-/" + "\n|    |" + "\n|" + "\n|" +"\n----------",
                        5: '------' + "\n|    |" + "\n|    0" + "\n|  /-+-/" + "\n|    |" + "\n|   |" + "\n|   |" +"\n----------",
                        6: '------' + "\n|    |" + "\n|    0" + "\n|  /-+-/" + "\n|    |" + "\n|   | |" + "\n|   | |" +"\n----------",
        }
        guessed = []
        wrong = 0
        word = ['test','python','abbey','abruptly','affix','askew','axiom','azure','bagpipes','bandwagon','banjo','bayou','bikini','blitz','bookworm','boxcar','boxful','buckaroo','buffalo','cobweb','croquet','daiquiri','disavow','duplex','dwarves','equip','exodus','fishhook','fixable','foxglove','galaxy','galvanize','gazebo','gizmo','glowworm','guffaw','haiku','haphazard','hyphen','icebox','injury','ivory','ivy','jaundice','jawbreaker','jaywalk','jazzy','jigsaw','jiujitsu','jockey','jovial','joyful','juicy','jumbo','kazoo','keyhole','khaki','kilobyte','kiosk','kiwifruit','knapsack','larynx','luxury','marquis','megahertz','microwave','mystify','nightclub','nowadays','numbskull','ovary','oxidize','oxygen','pajama','peekaboo','pixel','pizazz','pneumonia','polka','quartz','quiz','quorum','razzmatazz','rhubarb','rickshaw','schizophrenia','sphinx','spritz','squawk','subway','swivel','topaz','unknown','unworthy','unzip','uptown','vaporize','vixen','vodka','vortex','walkway','waltz','wavy','waxy','wheezy','whisker','whomever','wimpy','wizard','woozy','xylophone','yachtsman','yippee','youthful','zephyr','zigzag','zilch','zodiac','zombie']
        word = choice(word)
        while(True):
                current = ''
                for l in word:
                        if(l in guessed):
                                current += l
                        else:
                                current += '-'
                print(hangmanVar[wrong])
                print('Hangman Word: ' + current)
                if(wrong > 5):
                        print('You have made too many incorrect guesses, the correct word was ' + word + '.')
                        break
                if(current == word):
                        print('Congratulations you have correctly guessed the word!')
                        break
                guess = input('Enter a letter: ')
                while(len(guess) != 1 and not guess.isdigit()):
                        guess = input('You can only guess a letter: ')
                while(guess in guessed):
                        guess = input('You have already guessed that letter, guess again: ')
                guessed.append(guess.lower())
                if(not guess in word):
                        wrong += 1
                
