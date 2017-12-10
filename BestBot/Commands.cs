using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestBot
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        private static Random random = new Random(DateTime.Now.Millisecond);

        [Command("Joke")]
        public async Task Joke()
        {
            string result = "";

            switch (random.Next(0, 36))
            {
                case 0:
                    result = "A bartender is just a pharmacist with a limited inventory.";

                    break;
                case 1:
                    result = "A man walks into a bar with a roll of tarmac under his arm and says: 'Pint please, and one for the road.'";

                    break;
                case 2:
                    result = "A man enters a store and says: '15 litres of wine please.' 'Did you bring a container for this ? ' 'You're speaking to it.'";

                    break;
                case 3:
                    result = "Temples are free to enter but still empty. Pubs charge to enter, but are full. People ignore inner peace & choose to pay for self destruction";

                    break;
                case 4:
                    result = "I was going to write a joke about alcoholic midgets but I don't want to lower the bar.";

                    break;
                case 5:
                    result = "Two midgets walk into a mini-bar.";

                    break;
                case 6:
                    result = "I was drinking at the bar last night, so I took a bus home...That may not be a big deal to you, but I've never driven a bus before.";

                    break;
                case 7:
                    result = "A hamburger walks into a bar and the bartender says, 'Sorry, we don't serve food in here.'";

                    break;
                case 8:
                    result = "A horse walks into a bar. The bartender says, 'So, why the long face?'";

                    break;
                case 9:
                    result = "A skeleton walks into a bar and says, 'Gimme a beer, and a mop.'";

                    break;
                case 10:
                    result = "A soccer ball walks into a bar. The bartender kicked him out.";

                    break;
                case 11:
                    result = "A magician walks down an alley and turns into a bar.";

                    break;
                case 12:
                    result = "A man walks into a bar. OUCH! You would have thought he would have seen it!";

                    break;
                case 13:
                    result = "A dyslexic guy walks into a bra.";

                    break;
                case 14:
                    result = "A neutron walks into a bar and orders a beer. The bartender sets the beer down and says, For you, no charge!";

                    break;
                case 15:
                    result = "An Irish man walks out of a bar. Hey, it COULD happen!";

                    break;
                case 16:
                    result = "A baby seal walks into a bar, and the bartender asks, 'What will it be, stranger?' 'Anything but a Canadian Club' replies the seal.";

                    break;
                case 17:
                    result = "A bartender walks into a church, a temple and a mosque. He has no idea how jokes work.";

                    break;
                case 18:
                    result = "A baseball walks into a bar, and the bartender throws it out.";

                    break;
                case 19:
                    result = "A bear walks into a bar and says, 'Bartender, I'd like a gin ..................... and tonic.' And the bartender says, 'Sure, but what's with the big pause?'";

                    break;
                case 20:
                    result = "A cable TV installer walks into a bar and orders a beer. The bartender says, 'You'll be served sometime between 7am and 2pm.'";

                    break;
                case 21:
                    result = "A drunk staggers out of a bar and runs right into two priests. He says, 'I'm Jesus Christ.' The first priest says, 'No son, you're not.' The drunk turns to the other priest. 'I'm Jesus Christ.' The second priest replies, 'No, son, you're not.' So the drunk says, 'Look, I can prove it.' He walks back into the bar with the two priests. The bartender takes one look at the drunk and exclaims, 'Jesus Christ, you're here again?'";

                    break;
                case 22:
                    result = "A drunk staggers out of a bar and sees a nun standing at a bus stop. He walks up to her and punches her in the face. When she falls to the ground, he starts screaming, 'You're not so tough now, are you, Batman?'";

                    break;
                case 23:
                    result = "A drunk walks into a bar. 'Ouch!' he says.";

                    break;
                case 24:
                    result = "A fish walks into a bar. The bartender says, 'What will it be?' The fish croaks, 'Water.'";

                    break;
                case 25:
                    result = "A french fry walks into a bar and says to the bartender, 'Hey, could I get a beer please?' The bartender looks at him shaking his head and says, 'No, we don't serve food here.'";

                    break;
                case 26:
                    result = "Descartes walks into a bar, and the bartender asks 'Would you like a beer?' Descartes replies, 'I think not' and poof! he vanishes.";

                    break;
                case 27:
                    result = "E-flat walks into a bar. The bartender says, 'Sorry, we don't serve minors.'";

                    break;
                case 28:
                    result = "Jesus Christ walks into a bar and says, 'I'll just have a glass of water.'";

                    break;
                case 29:
                    result = "Julius Caesar walks into a bar. 'I'll have a martinus,' he says. The bartender gives him a puzzled look and asks, 'Don't you mean a martini?' 'Look,' Caesar retorts, 'If I wanted a double, I'd have asked for it!'";

                    break;
                case 30:
                    result = "The past, the present, and the future walk into a bar. Then things get tense.";

                    break;
                case 31:
                    result = "Thomas Edison walks into a bar and orders a beer. The bartender says, 'Okay, I'll serve you a beer. Just don't get any ideas.'";

                    break;
                case 32:
                    result = "Two guys walk into a bar. The third one ducks.";

                    break;
                case 33:
                    result = "Two jumber cables walk into a bar. The bartender says, 'You guys better not start anything in here!'";

                    break;
                case 34:
                    result = "Two guys are walking their dogs, one of which is a black lab and the other a Chihuahua. Passing a bar, the lab walker says, 'Let's get a beer.' The other guy retorts, 'We can't take our dogs in there,' and the first guy says, 'Watch.' In he goes and orders a beer. 'Sorry, you can't bring your dog in here,' says the bartender. 'But he's my seeing eye dog.' 'Oh, okay. Here's your beer.' Convinced, the Chihuahua owner follows, orders a beer, and gets the same response-No beer. 'But he's my seeing eye dog,' he pleads. 'Yeah, right,' replies the bartender. 'A Chihuahua as a seeing eye dog? Gimme a break.' 'They gave me a Chihuahua?'";

                    break;
                case 35:
                    result = "Fuck off.";

                    break;
            }

            await Context.Channel.SendMessageAsync(result);
        }

        [Command("Sass")]
        public async Task Sass()
        {
            string result = "";

            switch (random.Next(0, 12))
            {
                case 0:
                    result = "The customer is alsways right, and the bartender decides who is still a customer. Love my job!";

                    break;
                case 1:
                    result = "Ashes to ashes, dust to dust, when life's a bitch, beer is a must.";

                    break;
                case 2:
                    result = "Rule #1: the bartender is alwasy right. Rule #2: if the bartender is wrong, see rule #1";

                    break;
                case 3:
                    result = "I can do it a number of ways. Straight up, neat, on the rocks, or if you're flexible, with a twist.";

                    break;
                case 4:
                    result = "If you're drinking to forget, please pay in advance.";

                    break;
                case 5:
                    result = "Alcohol probably won't fix your problems...";

                    break;
                case 6:
                    result = "My demons can't swim in whiskey, but they sure try.";

                    break;
                case 7:
                    result = "Stop complaining. Being an adult is easy: Keep a few close friends, wear deodorant, and tip your bartender.";

                    break;
                case 8:
                    result = "Exercise makes you look better naked. So does tequila. Your choice.";

                    break;
                case 9:
                    result = "There's no need to repeat yourself. I ignored you just fine the first time.";

                    break;
                case 10:
                    result = "Please be patient with the bartender, even a toilet can serve only one asshole at a time.";

                    break;
                case 11:
                    result = "Cock!";

                    break;
            }

            await Context.Channel.SendMessageAsync(result);
        }

        [Command("Sass")]
        public async Task TestTask(IUser user)
        {
            string result = "";
            IUser creator = Context.Client.GetUser(228688913286299649);
            IUser targetedUser = Context.Client.GetUser(user.Username, user.Discriminator);

            if (targetedUser == creator)
            {
                result = "Are you fucking kidding me, " + Context.User.Mention + "? " + creator.Mention + " is my homie. Go fuck yourself.";
            }
            else
            {
                switch (random.Next(0, 13))
                {
                    case 0:
                        result = user.Mention + " you need to sit your ass down!";

                        break;
                    case 1:
                        result = "I think " + user.Mention + " has had one too many.";

                        break;
                    case 2:
                        result = user.Mention + ", you are cut off!";

                        break;
                    case 3:
                        result = user.Mention + ", shut the fuck up.";

                        break;
                    case 4:
                        result = "Hey " + user.Mention + ", you are pissing me off so seriously right now!";

                        break;
                    case 5:
                        result = "Maybe dice just is not your game, " + user.Mention;

                        break;
                    case 6:
                        result = user.Mention + " put the 'oron' in 'moron'";

                        break;
                    case 7:
                        result = user.Mention + " is a few fries short of a happy meal.";

                        break;
                    case 8:
                        result = user.Mention + ", I spit in your drink.";

                        break;
                    case 9:
                        result = user.Mention + ", do I need to call uber for you?";

                        break;
                    case 10:
                        result = user.Mention + ", fuck you.";

                        break;
                    case 11:
                        result = Context.User.Mention + ", fuck you."; // Mentions the user who issued the command.

                        break;
                    case 12:
                        result = "Fuck you " + Context.User.Mention + ", I happen to like " + user.Mention + "!"; // Mentions the user who issued the command.

                        break;
                }
            }

            await Context.Channel.SendMessageAsync(result);
        }

        [Command("GiveShot")]
        public async Task Shot(IUser user, string shot)
        {
            await Context.Channel.SendMessageAsync(user.Mention + " takes a shot of " + shot);
        }

        [Command("Roll")]
        public async Task Roll(int diceNumber)
        {
            List<int> dice = new List<int>();
            string allRolledDice = "You rolled: ";

            if (diceNumber > 0 && diceNumber <= 5)
            {
                bool isFirst = true;

                for (int i = 0; i < diceNumber; i++)
                {
                    int roll = random.Next(1, 7);

                    dice.Add(roll);

                    if (isFirst == true)
                    {
                        allRolledDice += roll;
                        isFirst = false;
                    }
                    else
                    {
                        allRolledDice += ", " + roll;
                    }
                }

                await Context.Channel.SendMessageAsync(allRolledDice);
            }
            else if(diceNumber == 0)
            {
                await Context.Channel.SendMessageAsync("You didn't roll any dice, dipshit.");
            }
            else if (diceNumber < 0 || diceNumber > 5)
            {
                await Context.Channel.SendMessageAsync("You have to roll at least one die, and no more than 5.");
            }
        }

        [Command("NewGame")]
        public async Task BarRoll()
        {
            MyBot.game = new BarDice();

            await Context.Channel.SendMessageAsync(
                        "New game started!\nSay: 'bb game roll' to roll the dice.\nSay: 'bb game hold<dice number>' to hold a die.\nSay: 'bb game show' to show all of your dice.");
        }

        [Command("game")]
        public async Task BarRoll(string move)
        {
            string allRolledDice = "You rolled=> ";
            string allHeldDice = "You held=> ";
            string allDice = "These are all your dice=> ";

            switch (move)
            {
                case "show":
                    allDice += MyBot.game.ShowAllDice();

                    await Context.Channel.SendMessageAsync(allDice);

                    break;
                case "roll":
                    MyBot.game.Roll();
                    allRolledDice += MyBot.game.ShowRolledDice();
                    
                    await Context.Channel.SendMessageAsync(allRolledDice);

                    break;
                case "hold1":
                    MyBot.game.Hold(1);
                    allHeldDice += MyBot.game.ShowHeldDice();
                    await Context.Channel.SendMessageAsync(allHeldDice);

                    break;
                case "hold2":
                    MyBot.game.Hold(2);
                    allHeldDice += MyBot.game.ShowHeldDice();
                    await Context.Channel.SendMessageAsync(allHeldDice);

                    break;
                case "hold3":
                    MyBot.game.Hold(3);
                    allHeldDice += MyBot.game.ShowHeldDice();
                    await Context.Channel.SendMessageAsync(allHeldDice);

                    break;
                case "hold4":
                    MyBot.game.Hold(4);
                    allHeldDice += MyBot.game.ShowHeldDice();
                    await Context.Channel.SendMessageAsync(allHeldDice);

                    break;
                case "hold5":
                    MyBot.game.Hold(5);
                    allHeldDice += MyBot.game.ShowHeldDice();
                    await Context.Channel.SendMessageAsync(allHeldDice);

                    break;
                default:
                    await Context.Channel.SendMessageAsync(
                        "Say: 'bb barroll roll' to roll the dice.\nSay: 'bb barroll hold<dice number> to hold a die.");

                    break;
            }
        }
    }
}
