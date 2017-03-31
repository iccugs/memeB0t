using Discord;
using Discord.Audio;
using Discord.Commands;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscoBot
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var bot = new MyBot();
            Console.WriteLine("hey");
            while (true) ;
        }
    }
    class MyBot
    {
        DiscordClient discord;
        CommandService commands;

        Random rand;

        string[] freshestMemes;

        string[] randomTexts;

        public MyBot()
        {
            rand = new Random();

            freshestMemes = new string[]
            {
                "mem/mem1.jpg", // 0
                "mem/mem2.jpg", // 1
                "mem/mem3.jpg", // 2
                "mem/mem4.jpg", // 3
                "mem/mem5.jpg", // 4
                "mem/mem6.jpg", // 5
                "mem/mem7.png", // 6
                "mem/mem8.jpg", // 7
                "mem/mem9.jpg", // 8
                "mem/mem10.jpg", // 9
                "mem/mem11.png", // 10
                "mem/mem12.jpg", // 11
                "mem/mem13.jpg", // 12
                "mem/mem14.jpg", // 13
                "mem/mem15.jpg", // 14
                "mem/mem16.jpg", // 15
                "mem/mem17.jpg", // 16
                "mem/mem18.png", // 17
                "mem/mem19.png", // 18
                "mem/mem20.jpg", // 19
                "mem/mem21.jpg", // 20
                "mem/mem22.png", // 21
                "mem/mem23.jpg", // 22
                "mem/mem24.jpg", // 23
                "mem/mem25.jpg", // 24
                "mem/mem26.jpg", // 25
                "mem/mem27.jpg", // 26
                "mem/mem28.jpg", // 27
                "mem/mem29.jpg", // 28
                "mem/mem30.jpg", // 29
                "mem/mem31.jpg", // 30
                "mem/mem32.jpg", // 31
                "mem/mem33.jpg", // 32
                "mem/mem34.jpg", // 33
                "mem/mem35.jpg", // 34
                "mem/mem36.jpg", // 35
                "mem/mem37.jpg", // 36
                "mem/mem38.jpg", // 37
                "mem/mem39.jpg", // 38
                "mem/mem40.png", // 39
                "mem/mem41.jpg", // 40
                "mem/mem42.jpg", // 41
                "mem/mem43.jpg", // 42
                "mem/mem44.jpg", // 43
                "mem/mem45.jpg", // 44
                "mem/mem46.jpg", // 45
                "mem/mem47.jpg", // 46
                "mem/mem48.jpg", // 47
                "mem/mem49.png", // 48
                "mem/mem50.jpg", // 49
                "mem/mem51.jpg", // 50
                "mem/mem52.jpg", // 51
                "mem/mem53.jpg", // 52
                "mem/mem54.jpg", // 53
                "mem/mem55.jpg", // 54
                "mem/mem56.png", // 55
                "mem/mem57.png", // 56
                "mem/mem58.jpg", // 57
                "mem/mem59.jpg", // 58
                "mem/mem60.jpg", // 59
                "mem/mem61.jpg", // 60
                "mem/mem62.jpg", // 61
                "mem/mem63.jpg", // 62
                "mem/mem64.jpg", // 63
                "mem/mem65.jpg", // 64
                "mem/mem66.jpg", // 65
                "mem/mem67.jpg", // 66
                "mem/mem68.jpg", // 67
                "mem/mem69.jpg", // 68
                "mem/mem70.jpg", // 69
                "mem/mem71.jpg", // 70
                "mem/mem72.jpg", // 71
                "mem/mem73.jpg", // 72
                "mem/mem74.jpg", // 73
                "mem/mem75.jpg", // 74
                "mem/mem76.jpg", // 75
                "mem/mem77.jpg", // 76
                "mem/mem78.jpg", // 77
                "mem/mem79.jpg", // 78
                "mem/mem80.jpg", // 79
                "mem/mem81.jpg", // 80
                "mem/mem82.jpg", // 81
                "mem/mem83.jpg", // 82
                "mem/mem84.jpg", // 83
                "mem/mem85.jpg", // 84
                "mem/mem86.jpg", // 85
                "mem/mem87.jpg", // 86
                "mem/mem88.jpg", // 87
                "mem/mem89.jpg", // 88
                "mem/mem90.jpg", // 89
                "mem/mem91.jpg", // 90
                "mem/mem92.jpg", // 91
                "mem/mem93.jpg", // 92
                "mem/mem94.jpg", // 93
                "mem/mem95.jpg", // 94
                "mem/mem96.jpg", // 95
                "mem/mem97.jpg", // 96
                "mem/mem98.jpg", // 97
                "mem/mem99.jpg", // 98
                "mem/mem100.jpg", // 99
                "mem/mem101.jpg", // 100
                "mem/mem102.jpg", // 101
                "mem/mem103.jpg", // 102
                "mem/mem104.jpg", // 103
                "mem/mem105.jpg", // 104
                "mem/mem106.jpg", // 105
                "mem/mem107.jpg", // 106
                "mem/mem108.jpg", // 107
                "mem/mem109.jpg", // 108
                "mem/mem110.jpg", // 109
                "mem/mem111.jpg", // 110
                "mem/mem112.jpg", // 111
                "mem/mem113.png", // 112
                "mem/mem114.jpg", // 113
                "mem/mem115.jpg", // 114
                "mem/mem116.jpg", // 115
                "mem/mem117.jpg", // 116
                "mem/mem118.jpg", // 117
                "mem/mem119.jpg", // 118
                "mem/mem120.jpg", // 119
                "mem/mem121.jpg", // 120
                "mem/mem122.jpg", // 121
                "mem/mem123.jpg", // 122
                "mem/mem124.png", // 123
                "mem/mem125.jpg", // 124
                "mem/mem126.jpg", // 125
                "mem/mem127.jpg", // 126
                "mem/mem128.jpg", // 127
                "mem/mem129.jpg", // 128
                "mem/mem130.jpg", // 129
                "mem/mem131.jpg", // 130
                "mem/mem132.jpg", // 131
                "mem/mem133.jpg", // 132
                "mem/mem134.jpg", // 133
                "mem/mem135.jpg", // 134
                "mem/mem136.jpg", // 135
                "mem/mem137.jpg", // 136
                "mem/mem138.jpg", // 137
                "mem/mem139.jpg", // 138
                "mem/mem140.jpg", // 139
                "mem/mem141.jpg", // 140
                "mem/mem142.jpg", // 141
                "mem/mem143.gif", // 142
                "mem/mem144.jpg", // 143
                "mem/mem145.jpg", // 144
                "mem/mem146.jpg", // 145
                "mem/mem147.jpg", // 146
                "mem/mem148.jpg", // 147
                "mem/mem149.gif", // 148
                "mem/mem150.jpg", // 149
                "mem/mem151.jpg", // 150
                "mem/mem152.png", // 151
                "mem/mem153.png", // 152
                "mem/mem154.jpg", // 153
                "mem/mem155.jpg", // 154
                "mem/mem156.jpg", // 155
                "mem/mem157.jpg", // 156
                "mem/mem158.jpg", // 157
                "mem/mem159.jpg", // 158
                "mem/mem160.jpg", // 159
                "mem/mem161.jpg", // 160
                "mem/mem162.jpg", // 161
                "mem/mem163.jpg", // 162
                "mem/mem164.jpg", // 163
                "mem/mem165.jpg", // 164
                "mem/mem166.jpg", // 165
                "mem/mem167.jpg", // 166
                "mem/mem168.jpg", // 167
                "mem/mem169.jpg", // 168
                "mem/mem170.jpg", // 169
                "mem/mem171.jpg", // 170
                "mem/mem172.jpg", // 171
                "mem/mem173.jpg", // 172
                "mem/mem174.jpg", // 173
                "mem/mem175.jpg", // 174
                "mem/mem176.png", // 175
                "mem/mem177.jpg", // 176
                "mem/mem178.jpg", // 177
                "mem/mem179.jpg", // 178
                "mem/mem180.jpg", // 179
                "mem/mem181.jpg", // 180
                "mem/mem182.jpg", // 181
                "mem/mem183.png", // 182
                "mem/mem184.jpg", // 183
                "mem/mem185.jpg", // 184
                "mem/mem186.jpg", // 185
                "mem/mem187.png", // 186
                "mem/mem188.jpg", // 187
                "mem/mem189.jpg", // 188
                "mem/mem190.jpg", // 189
                "mem/mem191.jpg", // 190
                "mem/mem192.jpg", // 191
                "mem/mem193.jpg", // 192
                "mem/mem194.gif", // 193
            };

            randomTexts = new string[]
            {
                "DO IT, just DO IT! Don’t let your dreams be dreams. Yesterday, you said tomorrow. So just. DO IT! Make. your dreams. COME TRUE! Just… do it! Some people dream of success, while you’re gonna wake up and work HARD at it! NOTHING IS IMPOSSIBLE!You should get to the point where anyone else would quit, and you’re not gonna stop there. NO! What are you waiting for? … DO IT! Just… DO IT! Yes you can! Just do it! If you’re tired of starting over, stop. giving. up.", // 0
                "What the fuck did you just fucking say about me, you little bitch? I’ll have you know I graduated top of my class in the Navy Seals, and I’ve been involved in numerous secret raids on Al-Quaeda, and I have over 300 confirmed kills. I am trained in gorilla warfare and I’m the top sniper in the entire US armed forces. You are nothing to me but just another target. I will wipe you the fuck out with precision the likes of which has never been seen before on this Earth, mark my fucking words. You think you can get away with saying that shit to me over the Internet? Think again, fucker. As we speak I am contacting my secret network of spies across the USA and your IP is being traced right now so you better prepare for the storm, maggot. The storm that wipes out the pathetic little thing you call your life. You’re fucking dead, kid. I can be anywhere, anytime, and I can kill you in over seven hundred ways, and that’s just with my bare hands. Not only am I extensively trained in unarmed combat, but I have access to the entire arsenal of the United States Marine Corps and I will use it to its full extent to wipe your miserable ass off the face of the continent, you little shit. If only you could have known what unholy retribution your little “clever” comment was about to bring down upon you, maybe you would have held your fucking tongue. But you couldn’t, you didn’t, and now you’re paying the price, you goddamn idiot. I will shit fury all over you and you will drown in it. You’re fucking dead, kiddo.", // 1
                "What in Davy Jones’ locker did ye just bark at me, ye scurvy bilgerat? I’ll have ye know I be the meanest cutthroat on the seven seas, and I’ve led numerous raids on fishing villages, and raped over 300 wenches. I be trained in hit-and-run pillaging and be the deadliest with a pistol of all the captains on the high seas. Ye be nothing to me but another source o’ swag. I’ll have yer guts for garters and keel haul ye like never been done before, hear me true. You think ye can hide behind your newfangled computing device? Think twice on that, scallywag. As we parley I be contacting my secret network o’ pirates across the sea and yer port is being tracked right now so ye better prepare for the typhoon, weevil. The kind o’ monsoon that’ll wipe ye off the map. You’re sharkbait, fool. I can sail anywhere, in any waters, and can kill ye in o’er seven hundred ways, and that be just with me hook and fist. Not only do I be top o’ the line with a cutlass, but I have an entire pirate fleet at my beck and call and I’ll damned sure use it all to wipe yer arse off o’ the world, ye dog. If only ye had had the foresight to know what devilish wrath your jibe was about to incur, ye might have belayed the comment. But ye couldn’t, ye didn’t, and now ye’ll pay the ultimate toll, you buffoon. I’ll shit fury all over ye and ye’ll drown in the depths o’ it. You’re fish food now, lad.", //2
                "Wot the fok did ye just say 2 me m8? i dropped out of newcastle primary skool im the sickest bloke ull ever meet & ive nicked ova 300 chocolate globbernaughts frum tha corner shop. im trained in street fitin’ & im the strongest foker in tha entire newcastle gym. yer nothin to me but a cheeky lil bellend w/ a fit mum & fakebling", //3
                "helo my name is dongerino pasterino ヽ༼ຈل͜ຈ༽ﾉ, i am 69 year old donger from imaqtmeatloaf’s stream . 420 years ago i was kidnapped and put into a donger concentration camp for 9001 years. 1 year ago, imaqtlasagne and imaqtpie invaded the camp and rescued me. now i work as teacherino, passing down the wisdom of ( ͡° ͜ʖ ͡°) to young dongers.", //4
                "Gr8 b8, m8. I rel8, str8 appreci8, and congratul8. I r8 this b8 an 8/8. Plz no h8, I’m str8 ir8. Cre8 more, can’t w8. We should convers8, I won’t ber8, my number is 8888888, ask for N8. No calls l8 or out of st8. If on a d8, ask K8 to loc8. Even with a full pl8, I always have time to communic8 so don’t hesit8", // 5
                "˙ʇı ןןɐɔ noʎ ɹǝʌǝʇɐɥʍ ɹo ,ɐʇǝq, pǝɹǝpısuoɔ buıǝq ɟo ʞɔıs ɯ,ı ˙ʇı ʇnoqɐ ʎɹɔ oʇ ǝɯ oʇ ʞןɐʇ ʎןuo puɐ ‘ʇıɥs ǝʞıן ɯǝɥʇ ʇɐǝɹʇ oɥʍ sʎnb bɐqǝɥɔnop ɹǝʇɟɐ ob sʎɐʍןɐ sןɹıb ǝsǝɥʇ puǝ ǝɥʇ uı ˙ʎpɐן,ɯ ɹoɟ buıɥʇʎuɐ op pןnoʍ puɐ ‘qoظ ǝɔıu ɐ ʞɹoʍ ‘ʎnb ǝɔıu ɐ ɯ,ı ˙ǝuoz puǝıɹɟ ǝɥʇ uı ʇnd buıǝq sʎɐʍןɐ ı ɯɐ ʎɥʍ", // 6
                "Whenever I get a package of plain M&Ms, I make it my duty to continue the strength and robustness of the candy as a species. To this end, I hold M&M duels. Taking two candies between my thumb and forefinger, I apply pressure, squeezing them together until one of them cracks and splinters. That is the “loser,” and I eat the inferior one immediately. The winner gets to go another round. I have found that, in general, the brown and red M&Ms are tougher, and the newer blue ones are genetically inferior. I have hypothesized that the blue M&Ms as a race cannot survive long in the intense theater of competition that is the modern candy and snack-food world. Occasionally I will get a mutation, a candy that is misshapen, or pointier, or flatter than the rest. Almost invariably this proves to be a weakness, but on very rare occasions it gives the candy extra strength. In this way, the species continues to adapt to its environment. When I reach the end of the pack, I am left with one M&M, the strongest of the herd. Since it would make no sense to eat this one as well, I pack it neatly in an envelope and send it to M&M Mars, A Division of Mars, Inc., Hackettstown, NJ 17840-1503 U.S.A., along with a 3×5 card reading, “Please use this M&M for breeding purposes.” This week they wrote back to thank me, and sent me a coupon for a free 1/2 pound bag of plain M&Ms. I consider this “grant money.” I have set aside the weekend for a grand tournament. From a field of hundreds, we will discover the True Champion. There can be only one.", // 7
                "That’s it, I’m done. Fuck this chat. It’s devolved into a mass of retarded copy pastes and face spam. The quality of twitch chat has been declining for a while, but this is the last straw. That’s it. I’m done. I’m uninstalling the internet, chopping off my dick and moving to fucking Antarctica, at least the bacteria there will be fucking smarter discourse", // 8
                "Hello Alkaizer, this is Hollywood director and producer Eddy Pasterino. We would like you and fowtini to star in our new movie: Naked Skorñorita. You will go the the inn and see fowtini lying in Leah’s bed and she will want your Skorn but you say “No Skornerrino” and topdeck her. Pls no hastalapasta baberino.", // 9
                "LOL look at that screenshot! Has anyone really been far even as decided to use even go want to do look more like?", // 10
                "hi mi name es giorgio i woerk in potatoe faktory and since mi padre died in a donkey waggon accident i leav mi wife and ugli daughter to become a pro leagueue of leyendaerio player, everydai i watch rainamndio. i just wante to sai thank you veriyi much rauinmanio i improvd from bronce 5 to wood 7 in just 6 months. plz no copato pasterato dis is onli my life. i ALso killed mi dog. Sorry fo mi bad englando im not NA", // 11
                "I can no longer resist the pizza. I open the box and unzip my pants with my other hand. As I penetrate the gooey cheese, I moan in ecstacy. The mushrooms and Italian sausage are rough, but the sauce is deliciously soothing. I blow my load in seconds. As you leave the bathroom, I exit through the front door….", // 12
                "wtf his ult did like 3k damage how is that legit - leonardo da vinci 1496, founder of the Illuminati", // 13
                "Why am I always being put in the friend zone. I’m a nice guy, work a nice job, and would do anything for m’lady. In the end these girls always go after DOUCHEBAG guys who treat them like shit, and only talk to me to cry about it. I’m sick of being considered ‘beta’ or whatever you call it.", // 14
                "Hello. I am a 15 year old Rhinoceros. The only problem is that my horn on my head is soft and limp. As you may know this is very devastating to a rhino like myself. If there are any rhinos out there that can help me with my problem it would be appreciated. Please dont copy paste this. This is my story.", // 15
                "Avaunt! What affront didst thou just proclaimest against my honour, foul knave? I would that thou knowest I was knighted by King Richard the Lionheart himself, and I’ve taken part in numerous holy Crusades against the Saracen dogs, and I have slain over 300 heathens. I am trained in siege warfare and I’m the fairest knight in the entire kingdom. Thou’rt nothing to me, merely another knave. I shall smite thee with precision the likes of which has never been witnessed before in all of Christendom, markest my damned words. Thou believest thou wouldst escape retribution for such honourless words over the Internet? Methinks not, peasant. As we speaketh now I am contacting my secret network of spies across the whole of England and word of thy whereabouts is being delivered to me at this very moment so thou shouldst prepare for the storm, knave. The storm that purges Christendom of the pathetic thing thou callest an existence. Thou’rt already passed, peasant. I can be anywhere, at any time, and I can slay thee in over seven hundred ways, and that’s merely with the hilt of my sword. Not only am I extensively trained in swordsmanship, but I have access to the entire serjeanty of my lord King Richard and I will use it to its fullest extent to purge thy wretched soul from the face of the continent, foul knave. If only thou couldst have known what holy retribution thy wretched “clever” comment wouldst bring down upon thee, perhaps thou wouldst have held thy serpent tongue. But thou couldst not, thou didst not, and now thy blood shall be recompense for my dishonour, wretched villain. I shall rain fury from the heavens and thou shalt drown in it. Thou’rt already passed, peasant.", // 16
            };

            discord = new DiscordClient(x =>
            {
                x.LogLevel = LogSeverity.Info;
                x.LogHandler = Log;
            });

            discord.UsingCommands(x =>
            {
                x.PrefixChar = '!';
                x.AllowMentionPrefix = true;
            });

            commands = discord.GetService<CommandService>();

            CreateCommand();

            discord.ExecuteAndWait(async () =>
            {
                discord.MessageReceived += async (s, e) =>
                {
                    if (e.Message.IsAuthor) return;
                    if (e.Message.Text.ToLower().Contains("badword1") || e.Message.Text.ToLower().Contains("badword2") || e.Message.Text.ToLower().Contains("badword3")  || e.Message.Text.ToLower().Contains("badword4")  || e.Message.Text.ToLower().Contains("badword5")  || e.Message.Text.ToLower().Contains("badword6"))
                    {
                        if (e.Server.Id != SERVIDNUMBER) return;
                        await e.Message.Delete();
                        await e.User.SendMessage("Please stop using offensive language in the Chatroom.");
                    }
                    if (e.Message.Text.Contains("www.youtube.com") || e.Message.Text.Contains("youtu.be"))
                    {
                        if (e.Server.Id != SERVIDNUMBER) return;
                        var channel = e.Server.GetChannel(CHANNELIDNUMBER);
                        await channel.SendMessage(e.Message.Text);
                        await e.Message.Delete(); // Bot needs permissions to do this
                    }
                };
                await discord.Connect("BOT_TOKEN",TokenType.Bot);
            });
        }

        private void CreateCommand()
        {
            commands.CreateCommand("help")
                .Do(async (e) =>
                {
                    await e.User.SendMessage("!help !meme !pasta !rules !times is the current command list for the D_Gen Mansion.");
                });
            commands.CreateCommand("meme")
                .Do(async (e) =>
                {
                    int randomMemeIndex = rand.Next(freshestMemes.Length);
                    string memeToPost = freshestMemes[randomMemeIndex];
                    await e.Channel.SendFile(memeToPost);
                });
            commands.CreateCommand("pasta")
                .Do(async (e) =>
                {
                    int randomMemeIndex = rand.Next(randomTexts.Length);
                    string memeToPost = randomTexts[randomMemeIndex];
                    await e.Channel.SendMessage(memeToPost);
                });
            commands.CreateCommand("rules")
                .Do(async (e) =>
                {
                    await e.User.SendMessage("RULES\n\nLINEONE\n\nLINETWO");
                });
            commands.CreateCommand("times")
                .Do(async (e) =>
                {
                    await e.User.SendMessage("STREAM TIMES\n\nLINEONE\n\nLINETWO");
                });
        }

        private void Log(object sender, LogMessageEventArgs e)
        {
            Console.WriteLine(e.Message);
        }
    }
}