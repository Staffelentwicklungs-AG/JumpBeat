# JumpBeat<br/>
This game prototype was developed as part of a weekly student project within a game development training program. Each student group explores a different core mechanic inspired by modern AAA games but scaled down to fit a beginner-friendly scope using the Unity Engine (2D or 3D).<br/>
<br/>
The goal is to help students learn essential development workflows such as:<br/>
  -Scripting<br/>
  -Scene building<br/>
  -Asset integration<br/>
  -UI and UX basics<br/>
  -Simple game logic<br/>
<br/>
Each prototype features a unique gameplay twist (USP) and focuses on one specific mechanic or idea.<br/>
Inspired by: Hi-Fi Rush / Beat Saber<br/>
Genre: 2D Rhythm Platformer<br/>
USP: Player jumps and dodges obstacles in sync with the beat. Everything moves to the rhythm.<br/>
Main focus: Music synchronization, obstacle timing, rhythm logic.<br/>

Gameplay</br>
Player runs along sidescrolling platforms through the level, nonstop. Jump over Obstacles, smash opponents out of the way, keep up
the rhythm given by the music. Beating opponents that run towards the player rewards points, colliding with obstacles and enemies leads
to GameOver. Upon beating the level a summary of jumps and points should enhance player feeling.
</br></br>
FlowChart</br>
GameMenu	>	Play 		>	LevelSelection	> Level	>	LoadBackground and LoadLevelLayout	>	StartGame	>	AudioAmazing	>	Run(StandardAnimation)		>	CheckCollision	>	GameOver
																																		>	Jump<
																																		>	Strike	>	CountPoints<
																																	
			>	Options		>	Audio	>	AudioOptions<
							>	Video	>	VideoOptions<
							>	Controls	>	ControlsOptions<
			>	Save/Load	>	Save<
							>	Load<