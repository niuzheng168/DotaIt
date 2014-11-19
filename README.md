DotaIt
======
This is a project to analysis user behaviors in dem(aka dota2 replay) file.


###Parser
Actually it's a wrapped replay parser, the real parser comes from [YASHA](https://github.com/dotabuff/yasha). I dump them into a json format file, which you can see the samples in DotaIt.ReplayParser/DotaIt.ReplayParser.Test/TestData. Then use my .net libs to reload it. Of course it waste lot of IO time, but there is no other solutions, I don't know GO lang.

####  Parser Input Format
  - Replay Overall Info
    - It contains which hero user choose, user id in this match count from 1 to 10.
    - Which team win, if team has a name like Newbee, it will show in the file.
    - Match type, CW or Normal or sky ladder.
    - Ban/Pick info if it's CW match.
  - Combat Info
    - Gold  
      {   
        "Target": "npc_dota_hero_storm_spirit",   
        "Value": 625,  
        "Time": 771.3666  
      }  
      Target: the hero ID.  
      Value: the gold count.  
      Time: in second fromat.  
      Translate: The storm_spirit hero get 625 gold at 771 second.

    - XP    
      {  
        "Target": "npc_dota_hero_weaver",  
        "Value": 297,  
        "Time": 1754.4932  
      }  
      Translate: The weaver hero get 297 XP at 1754 second.
    - Purchase  
      {  
        "Time": 829.28577,  
        "Buyer": "npc_dota_hero_lion",  
        "Item": "item_boots"  
      }  
      Buyer: the hero who paid the money.  
      Item: what he buy.  
      Translate: Lion buy a boots at 829 second.(Note that you cannot know lion's hero number)
      
    - Item  
      {  
        "Target": "npc_dota_hero_batrider",  
        "User": "npc_dota_hero_ancient_apparition",  
        "Item": "item_ward_sentry",  
        "AttackerIsIllusion": false,  
        "TargetIsIllusion": false,  
        "Time": 842.8158,  
        "UserIsHero": true,  
        "TargetIsHero": true  
      }  
      User: Who use the item.
      Item: Use what.
      Target: If the target is not unknown, it may means one of below:
      1. Give a item to another hero.
      2. Use the item to another hero, like urn of shadows(gu hui, hong zhang)
      Note that if you use hong zhang to kill a  footman, target is unknown.  
      Translate: AA give his ward sentry to BAT.
      
    - Add Modifier  
      {  
        "Source": "dota_unknown",  
        "Target": "npc_dota_hero_elder_titan",  
        "Attacker": "npc_dota_hero_elder_titan",  
        "Modifier": "modifier_clarity_potion",  
        "AttackerIsIllusion": false,  
        "TargetIsIllusion": false,  
        "IsDebuff": false,  
        "Health": 361,  
        "Time": 993.7456,  
        "TargetSource": "dota_unknown",  
        "AttackerIsHero": true,  
        "TargetIsHero": true  
      }  
      Target: Who get the Modifier.  
      Modifier: What modifier the target get.  
      Attacker: If the source modifier comes from other unit.  
      Translate: Elder titan got a clarity potion buff, the clarity owned by himself.  
      
    - Remove Modifier  
      Refer Add Modifier  
      
    - Damage
      {  
        "Source": "npc_dota_hero_storm_spirit",  
        "Target": "npc_dota_creep_badguys_melee",  
        "Attacker": "npc_dota_hero_storm_spirit",  
        "Cause": "storm_spirit_static_remnant",  
        "AttackerIsIllusion": false,  
        "TargetIsIllusion": false,  
        "Value": 140,  
        "Health": 410,  
        "Time": 1148.5745,  
        "TargetSource": "npc_dota_creep_badguys_melee",  
        "AttackerIsHero": true,  
        "TargetIsHero": false  
      }  
      Source: Who really own the damage, aka, if target is down, who will get the gold and exp.
      Target: Who get the damage.
      Attacker: Who did the damage to target.
      Cause: What cause the damage, skill, normal attack?  
      Value: How many damage down.  
      Health: Target health after this damage.  
      Translate: Storm Sprit use static remnant to attack a melee, 140 damage down, the current health of melee is 410.  
    
    - Heal  
      Refer damage.  
      
    - Death  
      {  
        "Source": "npc_dota_hero_weaver",  
        "Target": "npc_dota_neutral_satyr_hellcaller",  
        "Attacker": "npc_dota_hero_weaver",  
        "Cause": "item_hand_of_midas",  
        "AttackerIsIllusion": false,  
        "TargetIsIllusion": false,  
        "Time": 1754.4932,  
        "TargetSource": "npc_dota_neutral_satyr_hellcaller",  
        "AttackerIsHero": true,  
        "TargetIsHero": false  
      }  
      Simply who killed who at what time with what.
      Translate: Wwaver killed Satyr by hand of midas.
      
      


