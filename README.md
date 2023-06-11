# Creative-Making-Game-Witch-Helen-

### Game Identity

2.5D open world survival game about a girl who travels through the forest in the Middle Ages.

### Story

![85a23983c2619b2da3bca0b976d87dfa](https://github.com/yanzhang22010/Creative-Making-Game-Witch-Helen-/assets/119860662/5ce5453f-c118-4b42-9866-5653716a00a5)

In the 15th century, a young girl named Helen, together with her parents and sister, led a tranquil life in a village. As they grew older, Helen and her sister's striking red hair and beauty began to attract attention and criticism within the village. The conspicuous red hair and beauty of Helen and her sister became the subject of discussions among the villagers. Unfortunately, it was during this period that a plague broke out in the village, and rumors from the city suggested a connection between the disease and witchcraft. Helen's sister was mistakenly accused of being a witch and subjected to cruel torture, ultimately being burned alive.

This event plunged the entire village into a state of anxiety and panic, with many women suffering the same fate of ruthless execution after being accused of witchcraft. In this moment of crisis, Helen's parents made the decision one night to take their innocent and ignorant daughter to the forest behind the village, hoping she could escape this dreadful fate. They told her that on the other side of the forest, there was a peaceful and beautiful kingdom where women could freely pursue all knowledge without inhibition.

In the forest, Helen continuously stumbled upon forbidden books and gradually pieced together the truth of their escape. She discovered that in that era, women who were too conspicuous were regarded as witches and suffered the same fate as her sister, being burned alive. This cruel reality further strengthened Helen's determination to pursue her own freedom and equality.

Finally, Helen crossed the forest and arrived at a land of enlightenment. There, she discovered a true kingdom of peace that welcomed and respected women, enabling them to freely pursue knowledge and develop their talents.

### Background

![v2-3ed1ac6ff7c2530f3cd2b9cfd6a235de_1440w](https://github.com/yanzhang22010/Creative-Making-Game-Witch-Helen-/assets/119860662/625258e2-551d-4c2c-a287-c36e7bb4bfc4)

The origins of witchcraft can be traced back to ancient times, although written records from that period are scarce. However, in medieval Western countries, witches seemed to garner unprecedented attention. By the 15th century, Christianity had subjected "witches" to three centuries of persecution, considering them as the cause of disasters. Over the course of hundreds of years, thousands of women were indiscriminately labeled as "witches" and became targets of religious persecution. Many innocent and vulnerable women were unjustly accused of witchcraft based on a single word or a minor action, and were subjected to cruel and inexplicable forms of punishment, such as burning at the stake or hanging. Female victims were denied any right to defense or the opportunity to hire legal representation. The sole evidence against them was often false accusations and forced confessions. Such practices, which are now viewed as absurd, were commonplace in the ignorant Europe of the Middle Ages, where a single case could captivate an entire nation. In order to hunt witches, the Church published the infamous book "Malleus Maleficarum" or "The Hammer of Witches," which provided detailed descriptions of specific interrogation methods and effective techniques for successful framing. There were no prosecution procedures, no defense attorneys, and the accused "witches" were denied the opportunity to defend themselves. The charges listed against them appear laughable and absurd from a modern perspective. Countless "witches" suffered brutal torture that led to their deaths.

### Game purpose

The objective of the game is to showcase the adventurous journey of Helen, a medieval girl, and emphasize the values of independence and equality for women. Through gameplay, players will personally experience Helen's growth and witness her resilience and courage in the face of adversity and oppression.

Helen lives in an era shrouded in plague and rumors of witchcraft, where her sister is wrongly identified as a witch and brutally executed. This story portrays the discrimination and persecution faced by women during that time, highlighting the unfair treatment they endured in society.

Helen's parents send her to the forest, informing her of a peaceful and prosperous kingdom on the other side, where women can freely pursue knowledge. By gradually discovering forbidden books and unraveling the truth within the forest, Helen uncovers the truth behind her sister's death and becomes aware of the challenges faced by women in that era.

Players will assume the role of Helen, engaging in exploration of an open world while solving puzzles, completing quests, and interacting with other characters. The game focuses on Helen's growth story, allowing players to experience the challenges women encounter in their pursuit of independence and equality, as well as the courage and determination they demonstrate.

Through the game's presentation, we aim to deepen players' understanding of the historical injustices and persecutions endured by women. This, in turn, can foster appreciation and reflection on the importance of creating an environment of independence and equality for women in modern society. We hope this story inspires players to recognize the significance of gender equality and motivates them to promote positive change in their real lives.

### Gameplay

1. Control the movement of the game character by tilting the glove back and forth, left and right.
2. You need to bend your fingers to pick food to increase the amount of blood, and collect the forbidden book to obtain pieces of memories to increase the spiritual value.
3. During the collection process will encounter the attacking monsters, through the battle to kill the monsters.
Win condition: collect all the forbidden books and blood is not zero
Failure condition: blood amount reaches 0
enemy behavior: move around food, attack when the character enters the range.

### Technology

On the technical side, we used Unity as the software platform for game development, which provides powerful tools and features to create high-quality game experiences.

During the development process, we first created the game scene, characters and base colliders based on the foundation of a 2D game. Then by rotating the camera angle to -45 degrees and writing code so that every element in the scene always faces the camera, we successfully built a simple 2.5D game environment. This design allows the player to play in a semi-stereoscopic world, increasing the visual level and visual effect of the game.

In the game scene, we set up some patrol points and added enemy characters. By writing code, we let the enemies patrol a fixed route and chase the player and attack within a certain range. Each individual character animation is then controlled using a hybrid tree for smooth character movement transitions and performance.

To increase the playability and strategy of the game, we designed a fruit picking mechanic where players can pick fruit to restore life points. In addition, we also added a scroll collection mechanism, players need to pick up scrolls to restore the plot and achieve the pass conditions.

Through the above technical choices and design, we are committed to creating a rich, challenging and engaging game experience for players.

### Physics Engine

In order to better exercise the Arduino knowledge we previously learned through the course, we chose to use Arduino to create external devices to enhance the game experience. After screening multiple sensors and considering multiple perspectives such as game fit, playability and smooth operation, we finally chose to use the MPU6050 gyroscope to control the character's movement and the bend sensor to control the character's picking and attacking actions. These sensor devices are integrated into an interesting game glove.

Through the MPU6050 gyroscope, players can control the movement of the characters in the game through the movement of their hands. With the sensitive sensing of the gyroscope, players can explore the open world of the game and interact with the environment in a natural and intuitive way.

In addition, we have used bending sensors that allow players to simulate the picking and attacking movements of the characters through the bending movements of their fingers. This near-real-action interaction will enhance player immersion and engagement, making the game experience more interesting and interactive.

The entire sensor unit is integrated into the game gloves, so players can simply put on the gloves and play the game directly. This design aims to provide an intuitive and fun way to interact, allowing players to better experience the world of the game and create a closer connection with the game characters.

By choosing such a physics engine, we aim to provide a unique and creative gaming experience, while learning to apply our Arduino knowledge in practice to further enhance our capabilities in physical computing and interactive design.

