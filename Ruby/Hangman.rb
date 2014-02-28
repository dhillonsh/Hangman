#!C:\Ruby200\bin\ruby.exe
puts "\nHangman Game [Ruby]\n"
while true
	hangmanVar = {
			0 => '------' + "\n|    |" + "\n|" + "\n|" + "\n|" + "\n|" + "\n|" +"\n----------",
			1 => '------' + "\n|    |" + "\n|    0" + "\n|" + "\n|" + "\n|" + "\n|" +"\n----------",
			2 => '------' + "\n|    |" + "\n|    0" + "\n|   -+-" + "\n|" + "\n|" + "\n|" +"\n----------",
			3 => '------' + "\n|    |" + "\n|    0" + "\n|  /-+-" + "\n|" + "\n|" + "\n|" +"\n----------",
			4 => '------' + "\n|    |" + "\n|    0" + "\n|  /-+-/" + "\n|    |" + "\n|" + "\n|" +"\n----------",
			5 => '------' + "\n|    |" + "\n|    0" + "\n|  /-+-/" + "\n|    |" + "\n|   |" + "\n|   |" +"\n----------",
			6 => '------' + "\n|    |" + "\n|    0" + "\n|  /-+-/" + "\n|    |" + "\n|   | |" + "\n|   | |" +"\n----------",
		}
	word = ['test','python','abbey','abruptly','affix','askew','axiom','azure','bagpipes','bandwagon','banjo','bayou','bikini','blitz','bookworm','boxcar','boxful','buckaroo','buffalo','cobweb','croquet','daiquiri','disavow','duplex','dwarves','equip','exodus','fishhook','fixable','foxglove','galaxy','galvanize','gazebo','gizmo','glowworm','guffaw','haiku','haphazard','hyphen','icebox','injury','ivory','ivy','jaundice','jawbreaker','jaywalk','jazzy','jigsaw','jiujitsu','jockey','jovial','joyful','juicy','jumbo','kazoo','keyhole','khaki','kilobyte','kiosk','kiwifruit','knapsack','larynx','luxury','marquis','megahertz','microwave','mystify','nightclub','nowadays','numbskull','ovary','oxidize','oxygen','pajama','peekaboo','pixel','pizazz','pneumonia','polka','quartz','quiz','quorum','razzmatazz','rhubarb','rickshaw','schizophrenia','sphinx','spritz','squawk','subway','swivel','topaz','unknown','unworthy','unzip','uptown','vaporize','vixen','vodka','vortex','walkway','waltz','wavy','waxy','wheezy','whisker','whomever','wimpy','wizard','woozy','xylophone','yachtsman','yippee','youthful','zephyr','zigzag','zilch','zodiac','zombie']
	word = word.sample
	guessed = []
	wrong = 0
	while true
		current = ''
		for l in word.split('')
			if(guessed.include? l)
				current += l
			else
				current += " - "
			end
		end
		puts hangmanVar[wrong]
		puts "Hangman word: " + current
		if(wrong > 5)
				print('You have made too many incorrect guesses, the correct word was ' + word + '.')
				break
		end
		if(current == word)
				print('Congratulations you have correctly guessed the word!')
				break
		end
		
		puts "Guess a letter: "
		guess = gets.chomp[0]
		while !guess
			puts "You must guess a letter: "
			guess = gets.chomp[0]
		end
		while guessed.include? guess
			puts 'You have already guessed that letter, guess again: '
			guess = gets.chomp[0]
		end
		
		guessed.push(guess)
		if(!word.split('').include? guess)
			wrong += 1
		end
		
	end
end