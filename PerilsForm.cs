using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _40k_GM_Kit
{
    public partial class PerilsForm : Form
    {

        public PerilsForm()
        {
            InitializeComponent();

            phenomenaTitle.BackColor = Color.Transparent;
            phenomenaTitle2.BackColor = Color.Transparent;
            phenomenaRoll.BackColor = Color.Transparent;
            phenomenaRoll2.BackColor = Color.Transparent;
            perilNotice.BackColor = Color.Transparent;
            perilNotice2.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            perilNotice.Text = "";

            Random rnd = new Random();
            int roll = rnd.Next(1, 100),
                userVal;
            if (int.TryParse(phenomenaMod.Text, out userVal))
            {
                userVal = int.Parse(phenomenaMod.Text);
            }
            else
            {
                userVal = 0;
            }

            phenomenaRoll.Text = roll.ToString() + " + " + userVal.ToString();
            
            if (roll >=1 && roll <= 3)
            {
                phenomenaTitle.Text = "Dark Foreboding:";
                phenomenaDesc.Text = "A faint breeze blows past the psyker and those near him, and everyone gets the feeling that somewhere in the galaxy something unfortunate just happened.";
            }

            else if (roll >= 4 && roll <= 5)
            {
                phenomenaTitle.Text = "Warp Echo:";
                phenomenaDesc.Text = "For a few moments, all noises cause echoes, regardless of the surroundings.";
            }

            else if (roll >= 6 && roll <= 8)
            {
                phenomenaTitle.Text = "Unholy Stench:";
                phenomenaDesc.Text = "The air around the psyker becomes permeated with a bizarre and foul smell.";
            }

            else if (roll >= 9 && roll <= 11)
            {
                phenomenaTitle.Text = "Mind Warp:";
                phenomenaDesc.Text = "The psyker suffers a –5 penalty to Willpower Tests until the start of his next turn as his own inherent phobias, suspicions, and hatreds surge to the surface of his mind in a wave of unbound emotion.";
            }

            else if (roll >= 12 && roll <= 14)
            {
                phenomenaTitle.Text = "Hoarfrost:";
                phenomenaDesc.Text = "The temperature plummets for an instant, and a thin coating of frost forms to cover everything within 3d10 metres.";
            }

            else if (roll >= 15 && roll <= 17)
            {
                phenomenaTitle.Text = "Aura of Taint:";
                phenomenaDesc.Text = "All animals within 1d100 metres become spooked and agitated; characters with Psyniscience can pinpoint the psyker as the cause.";
            }

            else if (roll >= 18 && roll <= 20)
            {
                phenomenaTitle.Text = "Memory Worm:";
                phenomenaDesc.Text = "All people within line of sight of the psyker forget something trivial.";
            }

            else if (roll >= 21 && roll <= 23)
            {
                phenomenaTitle.Text = "Spoilage:";
                phenomenaDesc.Text = "Food and drink go bad in a 5d10 metre radius.";
            }

            else if (roll >= 24 && roll <= 26)
            {
                phenomenaTitle.Text = "Haunting Breeze:";
                phenomenaDesc.Text = "Winds whip up around the psyker for a few moments, blowing light objects around and guttering fires within 3d10 metres.";
            }

            else if (roll >= 27 && roll <= 29)
            {
                phenomenaTitle.Text = "Veil of Darkness:";
                phenomenaDesc.Text = "For a brief moment (effectively the remainder of the Round), the area within 3d10 metres is plunged into immediate darkness.";
            }

            else if (roll >= 30 && roll <= 32)
            {
                phenomenaTitle.Text = "Distorted Reflections:";
                phenomenaDesc.Text = "Mirrors and other reflective surfaces within a radius of 5d10 metres distort or shatter.";
            }

            else if (roll >= 33 && roll <= 35)
            {
                phenomenaTitle.Text = "Breath Leech:";
                phenomenaDesc.Text = "Everyone (including the psyker) within a 3d10 metre radius becomes short of breath for one round and cannot make any Run or Charge Actions.";
            }

            else if (roll >= 36 && roll <= 38)
            {
                phenomenaTitle.Text = "Daemonic Mask:";
                phenomenaDesc.Text = "For a fleeting moment, the psyker takes on a daemonic appearance and gains a Fear rating of 1 until the start of the next turn. However, he also gains one Corruption Point.";
            }

            else if (roll >= 39 && roll <= 41)
            {
                phenomenaTitle.Text = "Unnatural Decay:";
                phenomenaDesc.Text = "All plant life within 3d10 metres of the psyker withers and dies.";
            }

            else if (roll >= 42 && roll <= 44)
            {
                phenomenaTitle.Text = "Spectral Gale:";
                phenomenaDesc.Text = "Howling winds erupt around the psyker, requiring him and everyone within 4d10 metres to make an Easy (+30) Agility or Strength Test to avoid being knocked to the ground.";
            }

            else if (roll >= 45 && roll <= 47)
            {
                phenomenaTitle.Text = "Bloody Tears:";
                phenomenaDesc.Text = "Blood weeps from stone and wood within 3d10 metres of the psyker. If there are any pictures or statues of people inside this area, they appear to be crying blood.";
            }

            else if (roll >= 48 && roll <= 50)
            {
                phenomenaTitle.Text = "The Earth Protests:";
                phenomenaDesc.Text = "The ground suddenly shakes, and everyone (including the psyker) within a 5d10 metre radius must make a Routine (+10) Agility Test or be knocked down";
            }

            else if (roll >= 51 && roll <= 53)
            {
                phenomenaTitle.Text = "Actinic Discharge:";
                phenomenaDesc.Text = "Static electricity fills the air within 5d10 metres causing hair to stand on end and unprotected electronics to short out, while the psyker is wreathed in eldritch lightning";
            }

            else if (roll >= 54 && roll <= 56)
            {
                phenomenaTitle.Text = "Warp Ghosts:";
                phenomenaDesc.Text = "Ghostly apparitions fill the air within 3d10 metres around the psyker, flying about and howling in pain for a few brief moments. Everyone in the radius (except the psyker himself ) must test against a Fear rating of 1.";
            }

            else if (roll >= 57 && roll <= 59)
            {
                phenomenaTitle.Text = "Falling Upwards:";
                phenomenaDesc.Text = "Everything within 2d10 metres of the psyker (including the psyker himself ) rises 1d10 metres into the air as gravity briefly ceases. Almost immediately, everything crashes back to earth, suffering falling Damage as appropriate for the distances fallen.";
            }

            else if (roll >= 60 && roll <= 62)
            {
                phenomenaTitle.Text = "Banshee Howl:";
                phenomenaDesc.Text = "A shrill keening rings out across the immediate area, shattering glass and forcing every mortal creature able to hear it (including the psyker) to pass a Challenging (+0) Toughness Test or be deafened for 1d10 rounds";
            }

            else if (roll >= 63 && roll <= 65)
            {
                phenomenaTitle.Text = "The Furies:";
                phenomenaDesc.Text = "The Psyker is assailed by unseen horrors. He is slammed to the ground and suffers 1d5 Damage (ignoring Armour, but not Toughness Bonus) and he must test against Fear (2)";
            }

            else if (roll >= 66 && roll <= 68)
            {
                phenomenaTitle.Text = "Shadow of the Warp:";
                phenomenaDesc.Text = " For a split second, the world changes in appearance, and everyone within 1d100 metres has brief but horrific glimpse of the shadow of the Warp. Everyone in the area (including the psyker) must make a Difficult (–10) Willpower Test or gain 1d5 Corruption Points.";
            }

            else if (roll >= 69 && roll <= 71)
            {
                phenomenaTitle.Text = "Tech Scorn:";
                phenomenaDesc.Text = "The machine spirits reject your unnatural ways. All un-warded technology within 5d10 metres malfunctions momentarily, and all ranged weapons Jam (see page 255), whilst characters with cybernetic implants must pass a Routine (+10) Toughness Test or suffer 1d5 Damage, ignoring Toughness Bonus and Armour.";
            }

            else if (roll >= 72 && roll <= 74)
            {
                phenomenaTitle.Text = "Warp Madness:";
                phenomenaDesc.Text = "A violent ripple of tainted discord causes all creatures within 2d10 metres (with the exception of the psyker) to become Frenzied for a Round and suffer 1d5 Corruption Points unless they can pass a Difficult (–10) Willpower Test.";
            }


            else if (roll >= 75)
            {
                roll = rnd.Next(1, 100);

                phenomenaRoll.Text = roll.ToString();

                perilNotice.Text = "Perhaps the Warp is too dangerous";

                if (roll >= 1 && roll <= 5)
                {
                    phenomenaTitle.Text = "The Gibbering:";
                    phenomenaDesc.Text = "The psyker screams in pain as uncontrolled Warp energies surge through his unprepared mind. He must make a Challenging (+0) Willpower Test or be stunned for 1d5 Rounds.";
                }

                if (roll >= 6 && roll <= 9)
                {
                    phenomenaTitle.Text = "Warp Burn:";
                    phenomenaDesc.Text = " A violent burst of energy from the Warp smashes into the psyker’s mind, sending him reeling. He suffers 2d5 Damage, ignoring Toughness Bonus and Armour, and is stunned for 1d5 Rounds.";
                }

                if (roll >= 10 && roll <= 13)
                {
                    phenomenaTitle.Text = "Psychic Concussion:";
                    phenomenaDesc.Text = "With a crack of energy, the psyker is knocked unconscious for 1d5 Rounds, and everyone within 3d10 metres must make a Routine (+10) Willpower Test or be Stunned for one Round.";
                }

                if (roll >= 14 && roll <= 18)
                {
                    phenomenaTitle.Text = "Psy Blast:";
                    phenomenaDesc.Text = "There is an explosion of power and the psyker is thrown 3d10 metres into the air, falling to the ground moments later (see page 267 for Falling Damage).";
                }

                if (roll >= 19 && roll <= 24)
                {
                    phenomenaTitle.Text = "Soul Sear:";
                    phenomenaDesc.Text = "Warp power courses through the psyker’s body, scorching his soul. The psyker cannot use any powers for the next hour and gains 2d5 Corruption Points.";
                }

                if (roll >= 25 && roll <= 30)
                {
                    phenomenaTitle.Text = "Locked In:";
                    phenomenaDesc.Text = "The power cages the psyker’s mind in an ethereal prison, tormented by visions of the Warp. The psyker falls to the ground in a catatonic state. Each Round thereafter, he must spend a Full Action to make a Difficult (–10) Willpower Test. On a success, his mind is freed and restored to his body, haunted by his experiences but otherwise unharmed.";
                }

                if (roll >= 31 && roll <= 38)
                {
                    phenomenaTitle.Text = "Chronological Incontinence:";
                    phenomenaDesc.Text = "Time warps around the psyker. He winks out of existence and reappears in 1d10 Rounds (or one minute in narrative time) in the exact location. He suffers one point of permanent Toughness and Intelligence damage as his body and mind rebel against the experience, and gains 1d5 Corruption Points.";
                }

                if (roll >= 39 && roll <= 46)
                {
                    phenomenaTitle.Text = "Psychic Mirror:";
                    phenomenaDesc.Text = "The psyker’s power is turned back on him. Resolve the power’s effects, but the power targets the psyker instead. If the power is beneficial, it deals 1d10+5 Energy Damage (ignoring Armour) to the psyker instead of its normal effect.";
                }

                if (roll >= 47 && roll <= 55)
                {
                    phenomenaTitle.Text = "Warp Whispers";
                    phenomenaDesc.Text = "The voices of daemons fill the air within 4d10 metres of the psyker, whispering terrible secrets and shocking truths. Everyone in the area (including the psyker ) must make a Hard (–20) Willpower Test or suffer 1d5 Corruption Points and an equal amount of Willpower damage. In addition, whether or not the psyker passes the Willpower Test, he suffers an additional 1d5+5 Willpower damage";
                }

                if (roll >= 56 && roll <= 58)
                {
                    phenomenaTitle.Text = "Vice Versa:";
                    phenomenaDesc.Text = "The psyker’s mind is thrown out of his body and into another nearby creature or person. The psyker and a random being (note, this cannot be a daemon, mindless xenos, or other “soulless” creature) within 50 metres swap consciousness for 1d10 rounds. This may be an ally or enemy. Each creature retains its Weapon Skill, Ballistic Skill, Intelligence, Perception, Willpower, and Fellowship during the swap, but all other Characteristics are of the new host body. If either body is slain, the effect ends immediately and both parties return to their original bodies. Both suffer 1d5 Intelligence damage from the experience. If there are no creatures within range, the psyker becomes catatonic for 1d5 rounds while his mind wanders the Warp. This journey causes 1d10 Willpower Damage, 1d10 Intelligence Damage and 1d10 Corruption Points.";
                }

                if (roll >= 59 && roll <= 67)
                {
                    phenomenaTitle.Text = "Dark Summoning:";
                    phenomenaDesc.Text = "The Empyrean buckles and tears at the arrogance of the psyker, and a Bloodletter rips its way into existence. (see Chapter XI: Adversaries). The fiend appears within 3d10 metres of the psyker, for a number of Rounds equal to 1d5 plus the psyker’s Toughness Bonus. The psyker’s turn immediately ends, and the Daemon may take its turn immediately. It detests the psyker and focuses all of its attacks upon the fool that unwittingly summoned it. It will not attack anyone else, even if others attack it.";
                }

                if (roll >= 68 && roll <= 72)
                {
                    phenomenaTitle.Text = "Rending the Veil:";
                    phenomenaDesc.Text = " The air vibrates with images of cackling daemons and the kaleidoscopic taint of the Warp is rendered visible. All sentient creatures (any creature with an Intelligence characteristic) within 1d100 metres must test against Fear (2). The psyker must Test against Fear (4) instead. This effect lasts for 1d5 Rounds.";
                }

                if (roll >= 73 && roll <= 78)
                {
                    phenomenaTitle.Text = "Blood Rain:";
                    phenomenaDesc.Text = "A psychic storm erupts, covering an area of 5d10 metres in which everyone must pass a Challenging (+0) Strength Test or be knocked to the ground. In addition to howling winds and the skies raining blood, any psychic powers used in the area for 1d5 Rounds automatically invoke Perils of the Warp, in addition to any Psychic Phenomena those powers cause. The psyker gains 1d5+1 Corruption Points.";
                }

                if (roll >= 79 && roll <= 82)
                {
                    phenomenaTitle.Text = "Cataclysmic Blast:";
                    phenomenaDesc.Text = "The psyker’s power overloads, arcing out in great bolts of Warp energy. Anyone within 1d10 metres (including the psyker) takes 1d10 Energy Damage with a Pen of 5. The psyker may not Dodge this, or stop the attack with a Field Save (see page 196). In addition, all of the psyker’s clothing and gear is destroyed, leaving him naked and smoking on the ground. The psyker may use no further powers for 1d5 hours after the event.";
                }

                if (roll >= 83 && roll <= 86)
                {
                    phenomenaTitle.Text = "Mass Possession:";
                    phenomenaDesc.Text = "Daemons ravage the mind of every living thing within 1d100 metres. Every character in the area must resist a possession attack (see the Possession Trait in Chapter V: Talents and Traits; the attacker is a random Lesser Daemon). This possession will last for no more than 2d10 Rounds, after which the daemons are cast back into the Warp.";
                }

                if (roll >= 87 && roll <= 90)
                {
                    phenomenaTitle.Text = "Reality Quake:";
                    phenomenaDesc.Text = "Reality buckles around the psyker, and an area radiating out 3d10 metres from him is sundered: solid objects alternately rot, burn, and freeze, and everyone and everything in the area takes 2d10 Rending Damage, ignoring Armour (and unable to be dodged). Warded objects, daemons, and untouchables halve the Damage rolled.";
                }

                if (roll >= 91 && roll <= 99)
                {
                    phenomenaTitle.Text = "Grand Possession:";
                    phenomenaDesc.Text = "A grand and terrible Warp entity takes interest in the psyker’s soul, descending from the Warp to seize the mortal’s body for its own purposes. A powerful Daemon attempts to possess the psyker (see the Possession Trait in Chapter IV: Talents and Traits). Use the Bloodletter from page 354, but increase all of its Characteristics by +20 and give it Fear 4. Even if the daemon fails, the psyker still suffers 2d10 Toughness Damage, and will forever add +10 to all rolls on the Psychic Phenomena and Perils of the Warp tables as his body now serves as a conduit to the power of the Warp. If the character dies while possessed, the daemon manifests in the real world for a number of days equal to its Toughness Bonus or until it is destroyed.";
                }

                if (roll == 100)
                {
                    phenomenaTitle.Text = "Annihilation:";
                    phenomenaDesc.Text = "The psyker is immediately and irrevocably destroyed, burned to nothing by the screaming fires of the Immaterium or dragged into the deepest maelstrom of the Warp. The psyker may not spend Fate to recover from this death, he is irrevocably destroyed. There is a chance that a daemonic entity of some sort appears in the psyker’s place—the type of daemon that appears is determined by the GM, based on how powerful the psyker was—more powerful psykers draw more powerful daemons. The percentage chance that the daemon appears is equal to the psyker’s Willpower characteristic (roll a d100, if the result is equal to or under the characteristic, the daemon appears).";
                }
            }

            phenomenaMod.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            perilNotice2.Text = "";

            Random rnd = new Random();
            int roll = rnd.Next(1, 100),
                userVal;
            if (int.TryParse(phenomenaMod2.Text, out userVal))
            {
                userVal = int.Parse(phenomenaMod2.Text);
            }
            else
            {
                userVal = 0;
            }

            phenomenaRoll2.Text = roll.ToString() + " + " + userVal.ToString();

            if (roll >= 1 && roll <= 3)
            {
                phenomenaTitle2.Text = "Dark Foreboding:";
                phenomenaDesc2.Text = "A faint breeze blows past the psyker and those near him, and everyone gets the feeling that somewhere in the galaxy something unfortunate just happened.";
            }

            else if (roll >= 4 && roll <= 5)
            {
                phenomenaTitle2.Text = "Warp Echo:";
                phenomenaDesc2.Text = "For a few moments, all noises cause echoes, regardless of the surroundings.";
            }

            else if (roll >= 6 && roll <= 8)
            {
                phenomenaTitle2.Text = "Unholy Stench:";
                phenomenaDesc2.Text = "The air around the psyker becomes permeated with a bizarre and foul smell.";
            }

            else if (roll >= 9 && roll <= 11)
            {
                phenomenaTitle2.Text = "Mind Warp:";
                phenomenaDesc2.Text = "The psyker suffers a –5 penalty to Willpower Tests until the start of his next turn as his own inherent phobias, suspicions, and hatreds surge to the surface of his mind in a wave of unbound emotion.";
            }

            else if (roll >= 12 && roll <= 14)
            {
                phenomenaTitle2.Text = "Hoarfrost:";
                phenomenaDesc2.Text = "The temperature plummets for an instant, and a thin coating of frost forms to cover everything within 3d10 metres.";
            }

            else if (roll >= 15 && roll <= 17)
            {
                phenomenaTitle2.Text = "Aura of Taint:";
                phenomenaDesc2.Text = "All animals within 1d100 metres become spooked and agitated; characters with Psyniscience can pinpoint the psyker as the cause.";
            }

            else if (roll >= 18 && roll <= 20)
            {
                phenomenaTitle2.Text = "Memory Worm:";
                phenomenaDesc2.Text = "All people within line of sight of the psyker forget something trivial.";
            }

            else if (roll >= 21 && roll <= 23)
            {
                phenomenaTitle2.Text = "Spoilage:";
                phenomenaDesc2.Text = "Food and drink go bad in a 5d10 metre radius.";
            }

            else if (roll >= 24 && roll <= 26)
            {
                phenomenaTitle2.Text = "Haunting Breeze:";
                phenomenaDesc2.Text = "Winds whip up around the psyker for a few moments, blowing light objects around and guttering fires within 3d10 metres.";
            }

            else if (roll >= 27 && roll <= 29)
            {
                phenomenaTitle2.Text = "Veil of Darkness:";
                phenomenaDesc2.Text = "For a brief moment (effectively the remainder of the Round), the area within 3d10 metres is plunged into immediate darkness.";
            }

            else if (roll >= 30 && roll <= 32)
            {
                phenomenaTitle2.Text = "Distorted Reflections:";
                phenomenaDesc2.Text = "Mirrors and other reflective surfaces within a radius of 5d10 metres distort or shatter.";
            }

            else if (roll >= 33 && roll <= 35)
            {
                phenomenaTitle2.Text = "Breath Leech:";
                phenomenaDesc2.Text = "Everyone (including the psyker) within a 3d10 metre radius becomes short of breath for one round and cannot make any Run or Charge Actions.";
            }

            else if (roll >= 36 && roll <= 38)
            {
                phenomenaTitle2.Text = "Daemonic Mask:";
                phenomenaDesc2.Text = "For a fleeting moment, the psyker takes on a daemonic appearance and gains a Fear rating of 1 until the start of the next turn. However, he also gains one Corruption Point.";
            }

            else if (roll >= 39 && roll <= 41)
            {
                phenomenaTitle2.Text = "Unnatural Decay:";
                phenomenaDesc2.Text = "All plant life within 3d10 metres of the psyker withers and dies.";
            }

            else if (roll >= 42 && roll <= 44)
            {
                phenomenaTitle2.Text = "Spectral Gale:";
                phenomenaDesc2.Text = "Howling winds erupt around the psyker, requiring him and everyone within 4d10 metres to make an Easy (+30) Agility or Strength Test to avoid being knocked to the ground.";
            }

            else if (roll >= 45 && roll <= 47)
            {
                phenomenaTitle2.Text = "Bloody Tears:";
                phenomenaDesc2.Text = "Blood weeps from stone and wood within 3d10 metres of the psyker. If there are any pictures or statues of people inside this area, they appear to be crying blood.";
            }

            else if (roll >= 48 && roll <= 50)
            {
                phenomenaTitle2.Text = "The Earth Protests:";
                phenomenaDesc2.Text = "The ground suddenly shakes, and everyone (including the psyker) within a 5d10 metre radius must make a Routine (+10) Agility Test or be knocked down";
            }

            else if (roll >= 51 && roll <= 53)
            {
                phenomenaTitle2.Text = "Actinic Discharge:";
                phenomenaDesc2.Text = "Static electricity fills the air within 5d10 metres causing hair to stand on end and unprotected electronics to short out, while the psyker is wreathed in eldritch lightning";
            }

            else if (roll >= 54 && roll <= 56)
            {
                phenomenaTitle2.Text = "Warp Ghosts:";
                phenomenaDesc2.Text = "Ghostly apparitions fill the air within 3d10 metres around the psyker, flying about and howling in pain for a few brief moments. Everyone in the radius (except the psyker himself ) must test against a Fear rating of 1.";
            }

            else if (roll >= 57 && roll <= 59)
            {
                phenomenaTitle2.Text = "Falling Upwards:";
                phenomenaDesc2.Text = "Everything within 2d10 metres of the psyker (including the psyker himself ) rises 1d10 metres into the air as gravity briefly ceases. Almost immediately, everything crashes back to earth, suffering falling Damage as appropriate for the distances fallen.";
            }

            else if (roll >= 60 && roll <= 62)
            {
                phenomenaTitle2.Text = "Banshee Howl:";
                phenomenaDesc2.Text = "A shrill keening rings out across the immediate area, shattering glass and forcing every mortal creature able to hear it (including the psyker) to pass a Challenging (+0) Toughness Test or be deafened for 1d10 rounds";
            }

            else if (roll >= 63 && roll <= 65)
            {
                phenomenaTitle2.Text = "The Furies:";
                phenomenaDesc2.Text = "The Psyker is assailed by unseen horrors. He is slammed to the ground and suffers 1d5 Damage (ignoring Armour, but not Toughness Bonus) and he must test against Fear (2)";
            }

            else if (roll >= 66 && roll <= 68)
            {
                phenomenaTitle2.Text = "Shadow of the Warp:";
                phenomenaDesc2.Text = " For a split second, the world changes in appearance, and everyone within 1d100 metres has brief but horrific glimpse of the shadow of the Warp. Everyone in the area (including the psyker) must make a Difficult (–10) Willpower Test or gain 1d5 Corruption Points.";
            }

            else if (roll >= 69 && roll <= 71)
            {
                phenomenaTitle2.Text = "Tech Scorn:";
                phenomenaDesc2.Text = "The machine spirits reject your unnatural ways. All un-warded technology within 5d10 metres malfunctions momentarily, and all ranged weapons Jam (see page 255), whilst characters with cybernetic implants must pass a Routine (+10) Toughness Test or suffer 1d5 Damage, ignoring Toughness Bonus and Armour.";
            }

            else if (roll >= 72 && roll <= 74)
            {
                phenomenaTitle2.Text = "Warp Madness:";
                phenomenaDesc2.Text = "A violent ripple of tainted discord causes all creatures within 2d10 metres (with the exception of the psyker) to become Frenzied for a Round and suffer 1d5 Corruption Points unless they can pass a Difficult (–10) Willpower Test.";
            }


            else if (roll >= 75)
            {
                roll = rnd.Next(1, 100);

                phenomenaRoll2.Text = roll.ToString();

                perilNotice2.Text = "Perhaps the Warp is too dangerous";

                if (roll >= 1 && roll <= 5)
                {
                    phenomenaTitle2.Text = "The Gibbering:";
                    phenomenaDesc2.Text = "The psyker screams in pain as uncontrolled Warp energies surge through his unprepared mind. He must make a Challenging (+0) Willpower Test or be stunned for 1d5 Rounds.";
                }

                if (roll >= 6 && roll <= 9)
                {
                    phenomenaTitle2.Text = "Warp Burn:";
                    phenomenaDesc2.Text = " A violent burst of energy from the Warp smashes into the psyker’s mind, sending him reeling. He suffers 2d5 Damage, ignoring Toughness Bonus and Armour, and is stunned for 1d5 Rounds.";
                }

                if (roll >= 10 && roll <= 13)
                {
                    phenomenaTitle2.Text = "Psychic Concussion:";
                    phenomenaDesc2.Text = "With a crack of energy, the psyker is knocked unconscious for 1d5 Rounds, and everyone within 3d10 metres must make a Routine (+10) Willpower Test or be Stunned for one Round.";
                }

                if (roll >= 14 && roll <= 18)
                {
                    phenomenaTitle2.Text = "Psy Blast:";
                    phenomenaDesc2.Text = "There is an explosion of power and the psyker is thrown 3d10 metres into the air, falling to the ground moments later (see page 267 for Falling Damage).";
                }

                if (roll >= 19 && roll <= 24)
                {
                    phenomenaTitle2.Text = "Soul Sear:";
                    phenomenaDesc2.Text = "Warp power courses through the psyker’s body, scorching his soul. The psyker cannot use any powers for the next hour and gains 2d5 Corruption Points.";
                }

                if (roll >= 25 && roll <= 30)
                {
                    phenomenaTitle2.Text = "Locked In:";
                    phenomenaDesc2.Text = "The power cages the psyker’s mind in an ethereal prison, tormented by visions of the Warp. The psyker falls to the ground in a catatonic state. Each Round thereafter, he must spend a Full Action to make a Difficult (–10) Willpower Test. On a success, his mind is freed and restored to his body, haunted by his experiences but otherwise unharmed.";
                }

                if (roll >= 31 && roll <= 38)
                {
                    phenomenaTitle2.Text = "Chronological Incontinence:";
                    phenomenaDesc2.Text = "Time warps around the psyker. He winks out of existence and reappears in 1d10 Rounds (or one minute in narrative time) in the exact location. He suffers one point of permanent Toughness and Intelligence damage as his body and mind rebel against the experience, and gains 1d5 Corruption Points.";
                }

                if (roll >= 39 && roll <= 46)
                {
                    phenomenaTitle2.Text = "Psychic Mirror:";
                    phenomenaDesc2.Text = "The psyker’s power is turned back on him. Resolve the power’s effects, but the power targets the psyker instead. If the power is beneficial, it deals 1d10+5 Energy Damage (ignoring Armour) to the psyker instead of its normal effect.";
                }

                if (roll >= 47 && roll <= 55)
                {
                    phenomenaTitle2.Text = "Warp Whispers";
                    phenomenaDesc2.Text = "The voices of daemons fill the air within 4d10 metres of the psyker, whispering terrible secrets and shocking truths. Everyone in the area (including the psyker ) must make a Hard (–20) Willpower Test or suffer 1d5 Corruption Points and an equal amount of Willpower damage. In addition, whether or not the psyker passes the Willpower Test, he suffers an additional 1d5+5 Willpower damage";
                }

                if (roll >= 56 && roll <= 58)
                {
                    phenomenaTitle2.Text = "Vice Versa:";
                    phenomenaDesc2.Text = "The psyker’s mind is thrown out of his body and into another nearby creature or person. The psyker and a random being (note, this cannot be a daemon, mindless xenos, or other “soulless” creature) within 50 metres swap consciousness for 1d10 rounds. This may be an ally or enemy. Each creature retains its Weapon Skill, Ballistic Skill, Intelligence, Perception, Willpower, and Fellowship during the swap, but all other Characteristics are of the new host body. If either body is slain, the effect ends immediately and both parties return to their original bodies. Both suffer 1d5 Intelligence damage from the experience. If there are no creatures within range, the psyker becomes catatonic for 1d5 rounds while his mind wanders the Warp. This journey causes 1d10 Willpower Damage, 1d10 Intelligence Damage and 1d10 Corruption Points.";
                }

                if (roll >= 59 && roll <= 67)
                {
                    phenomenaTitle2.Text = "Dark Summoning:";
                    phenomenaDesc2.Text = "The Empyrean buckles and tears at the arrogance of the psyker, and a Bloodletter rips its way into existence. (see Chapter XI: Adversaries). The fiend appears within 3d10 metres of the psyker, for a number of Rounds equal to 1d5 plus the psyker’s Toughness Bonus. The psyker’s turn immediately ends, and the Daemon may take its turn immediately. It detests the psyker and focuses all of its attacks upon the fool that unwittingly summoned it. It will not attack anyone else, even if others attack it.";
                }

                if (roll >= 68 && roll <= 72)
                {
                    phenomenaTitle2.Text = "Rending the Veil:";
                    phenomenaDesc2.Text = " The air vibrates with images of cackling daemons and the kaleidoscopic taint of the Warp is rendered visible. All sentient creatures (any creature with an Intelligence characteristic) within 1d100 metres must test against Fear (2). The psyker must Test against Fear (4) instead. This effect lasts for 1d5 Rounds.";
                }

                if (roll >= 73 && roll <= 78)
                {
                    phenomenaTitle2.Text = "Blood Rain:";
                    phenomenaDesc2.Text = "A psychic storm erupts, covering an area of 5d10 metres in which everyone must pass a Challenging (+0) Strength Test or be knocked to the ground. In addition to howling winds and the skies raining blood, any psychic powers used in the area for 1d5 Rounds automatically invoke Perils of the Warp, in addition to any Psychic Phenomena those powers cause. The psyker gains 1d5+1 Corruption Points.";
                }

                if (roll >= 79 && roll <= 82)
                {
                    phenomenaTitle2.Text = "Cataclysmic Blast:";
                    phenomenaDesc2.Text = "The psyker’s power overloads, arcing out in great bolts of Warp energy. Anyone within 1d10 metres (including the psyker) takes 1d10 Energy Damage with a Pen of 5. The psyker may not Dodge this, or stop the attack with a Field Save (see page 196). In addition, all of the psyker’s clothing and gear is destroyed, leaving him naked and smoking on the ground. The psyker may use no further powers for 1d5 hours after the event.";
                }

                if (roll >= 83 && roll <= 86)
                {
                    phenomenaTitle2.Text = "Mass Possession:";
                    phenomenaDesc2.Text = "Daemons ravage the mind of every living thing within 1d100 metres. Every character in the area must resist a possession attack (see the Possession Trait in Chapter V: Talents and Traits; the attacker is a random Lesser Daemon). This possession will last for no more than 2d10 Rounds, after which the daemons are cast back into the Warp.";
                }

                if (roll >= 87 && roll <= 90)
                {
                    phenomenaTitle2.Text = "Reality Quake:";
                    phenomenaDesc2.Text = "Reality buckles around the psyker, and an area radiating out 3d10 metres from him is sundered: solid objects alternately rot, burn, and freeze, and everyone and everything in the area takes 2d10 Rending Damage, ignoring Armour (and unable to be dodged). Warded objects, daemons, and untouchables halve the Damage rolled.";
                }

                if (roll >= 91 && roll <= 99)
                {
                    phenomenaTitle2.Text = "Grand Possession:";
                    phenomenaDesc2.Text = "A grand and terrible Warp entity takes interest in the psyker’s soul, descending from the Warp to seize the mortal’s body for its own purposes. A powerful Daemon attempts to possess the psyker (see the Possession Trait in Chapter IV: Talents and Traits). Use the Bloodletter from page 354, but increase all of its Characteristics by +20 and give it Fear 4. Even if the daemon fails, the psyker still suffers 2d10 Toughness Damage, and will forever add +10 to all rolls on the Psychic Phenomena and Perils of the Warp tables as his body now serves as a conduit to the power of the Warp. If the character dies while possessed, the daemon manifests in the real world for a number of days equal to its Toughness Bonus or until it is destroyed.";
                }

                if (roll == 100)
                {
                    phenomenaTitle2.Text = "Annihilation:";
                    phenomenaDesc2.Text = "The psyker is immediately and irrevocably destroyed, burned to nothing by the screaming fires of the Immaterium or dragged into the deepest maelstrom of the Warp. The psyker may not spend Fate to recover from this death, he is irrevocably destroyed. There is a chance that a daemonic entity of some sort appears in the psyker’s place—the type of daemon that appears is determined by the GM, based on how powerful the psyker was—more powerful psykers draw more powerful daemons. The percentage chance that the daemon appears is equal to the psyker’s Willpower characteristic (roll a d100, if the result is equal to or under the characteristic, the daemon appears).";
                }
            }

            phenomenaMod2.SelectedIndex = -1;
        }
    }
}