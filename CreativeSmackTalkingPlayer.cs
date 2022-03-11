using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        private List<string> taunts = new List<string>() { "gid gud scrub", "you suck", "booooo", "YOU SUCK! You a no talent piece of shit. GET OUT! How dare you come down here and do this. Im here 14 years, I've lived in this town my whole life, you're a DISGRACE. YOU SUCK! Who the hell do you think you are? Who the hell do you think you are? You any kind of artist? Anybody know who you are?! Maybe everyone else wants to enjoy the peace and quiet. This is one of the most important places in all of North America, who are you? WHO ARE YOU?! You miserable, presumptuous NO TALENT. You're no artist. An artist respects the silence that serves the foundation of creativity. You OBVIOUSLY dont have the talent, You dont have enough respect for yourself or other people OR what it is to express yourself; In music or ANY other form of creativity. And i'm an NYU Film School graduate, SUCKA! And The School of Visual Arts, And The Academy of Art University San Fransisco. You SUCK. You're a NO talent. If you really had talent, go practice! And than get yourself a gig! Instead of ruining the end of the day for everybody down here. You DISGRACE!! You are everything thats gone wrong with this world. You're a self-consumed, no talent, mediocre piece of shit, and i've earned my right to say it. OKAY?! I had Two-Hundered-thousand people with Bill Graham, in 1975. I walked Bob Dylan up on stage, who the fuck are you? I knew the Grateful Dead from 1966, who the FUCK ARE YOU!? You're nothing, You're nothing, You are nothing and you will never be anything. Never. How dare you? How dare you? You miserable mediocre nothing! Shame on you. You cracked stupid little smile, you little PIMP. Go learn to play, Go learn to play, you're flat. You cant even carry a fuckin' note. I dont care about your little, like, horn lip. 'cause it doesn't mean you know how to play. you're flat! I'm trained CLASSICALLY, I'm trained contemporaneously, and you suck.", "you fool. you absolute baffoon. You think you can challenge me in my own realm? you think you can rebel against my authority? you dare come into my house and upturn my dining chairs and spill coffee grounds in my Keurig? you thought you were safe in your chain mail armor behind that screen of yours. I will take these laminate wood floor boards and destroy you. i didnt want war. but i didnt start it", "ur mom" };

        public override int Roll()
        {
            // Return a random number between 1 and DiceSize
            Console.WriteLine($"{Name} says: {taunts[new Random().Next(0, taunts.Count)]}");
            return new Random().Next(DiceSize) + 1;
        }
    }
}