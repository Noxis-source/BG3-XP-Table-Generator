using DevExpress.Mvvm;
using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Xml.Linq;

namespace GeneratorData {
    public class XPRewardsData : BindableBase {
        public const string XP_REWARDS_BASE =
@"<?xml version=""1.0"" encoding=""UTF-8""?>
<save>
    <version major=""4"" minor=""0"" revision=""9"" build=""307""/>
    <region id=""ExperienceRewards"">
        <node id=""root"">
            <children>
                <node id=""ExperienceReward"">
                    <attribute id=""Level1"" type=""uint32"" value=""0""/>
                    <attribute id=""Level10"" type=""uint32"" value=""0""/>
                    <attribute id=""Level11"" type=""uint32"" value=""0""/>
                    <attribute id=""Level12"" type=""uint32"" value=""0""/>
                    <attribute id=""Level2"" type=""uint32"" value=""0""/>
                    <attribute id=""Level3"" type=""uint32"" value=""0""/>
                    <attribute id=""Level4"" type=""uint32"" value=""0""/>
                    <attribute id=""Level5"" type=""uint32"" value=""0""/>
                    <attribute id=""Level6"" type=""uint32"" value=""0""/>
                    <attribute id=""Level7"" type=""uint32"" value=""0""/>
                    <attribute id=""Level8"" type=""uint32"" value=""0""/>
                    <attribute id=""Level9"" type=""uint32"" value=""0""/>
                    <attribute id=""Name"" type=""FixedString"" value=""Zero""/>
                    <attribute id=""RewardType"" type=""uint8"" value=""0""/>
                    <attribute id=""UUID"" type=""guid"" value=""40806669-8c6b-4068-8bc4-07e4981bb020""/>
                </node>
                <node id=""ExperienceReward"">
                    <attribute id=""Level1"" type=""uint32"" value=""1""/>
                    <attribute id=""Level10"" type=""uint32"" value=""1""/>
                    <attribute id=""Level11"" type=""uint32"" value=""1""/>
                    <attribute id=""Level12"" type=""uint32"" value=""1""/>
                    <attribute id=""Level2"" type=""uint32"" value=""1""/>
                    <attribute id=""Level3"" type=""uint32"" value=""1""/>
                    <attribute id=""Level4"" type=""uint32"" value=""1""/>
                    <attribute id=""Level5"" type=""uint32"" value=""1""/>
                    <attribute id=""Level6"" type=""uint32"" value=""1""/>
                    <attribute id=""Level7"" type=""uint32"" value=""1""/>
                    <attribute id=""Level8"" type=""uint32"" value=""1""/>
                    <attribute id=""Level9"" type=""uint32"" value=""1""/>
                    <attribute id=""Name"" type=""FixedString"" value=""Civilian""/>
                    <attribute id=""RewardType"" type=""uint8"" value=""0""/>
                    <attribute id=""UUID"" type=""guid"" value=""c83d6caa-c5c3-4356-b55c-8d634535976c""/>
                </node>
                <node id=""ExperienceReward"">
                    <attribute id=""Level1"" type=""uint32"" value=""3""/>
                    <attribute id=""Level10"" type=""uint32"" value=""135""/>
                    <attribute id=""Level11"" type=""uint32"" value=""170""/>
                    <attribute id=""Level12"" type=""uint32"" value=""210""/>
                    <attribute id=""Level2"" type=""uint32"" value=""5""/>
                    <attribute id=""Level3"" type=""uint32"" value=""10""/>
                    <attribute id=""Level4"" type=""uint32"" value=""20""/>
                    <attribute id=""Level5"" type=""uint32"" value=""40""/>
                    <attribute id=""Level6"" type=""uint32"" value=""50""/>
                    <attribute id=""Level7"" type=""uint32"" value=""60""/>
                    <attribute id=""Level8"" type=""uint32"" value=""75""/>
                    <attribute id=""Level9"" type=""uint32"" value=""110""/>
                    <attribute id=""LevelSource"" type=""uint8"" value=""1""/>
                    <attribute id=""Name"" type=""FixedString"" value=""Pack""/>
                    <attribute id=""RewardType"" type=""uint8"" value=""0""/>
                    <attribute id=""UUID"" type=""guid"" value=""c1d87aaa-7548-44da-b9dd-d17b027a3885""/>
                </node>
                <node id=""ExperienceReward"">
                    <attribute id=""Level1"" type=""uint32"" value=""10""/>
                    <attribute id=""Level10"" type=""uint32"" value=""250""/>
                    <attribute id=""Level11"" type=""uint32"" value=""320""/>
                    <attribute id=""Level12"" type=""uint32"" value=""400""/>
                    <attribute id=""Level2"" type=""uint32"" value=""15""/>
                    <attribute id=""Level3"" type=""uint32"" value=""20""/>
                    <attribute id=""Level4"" type=""uint32"" value=""40""/>
                    <attribute id=""Level5"" type=""uint32"" value=""75""/>
                    <attribute id=""Level6"" type=""uint32"" value=""90""/>
                    <attribute id=""Level7"" type=""uint32"" value=""110""/>
                    <attribute id=""Level8"" type=""uint32"" value=""140""/>
                    <attribute id=""Level9"" type=""uint32"" value=""200""/>
                    <attribute id=""LevelSource"" type=""uint8"" value=""1""/>
                    <attribute id=""Name"" type=""FixedString"" value=""Combatant""/>
                    <attribute id=""RewardType"" type=""uint8"" value=""0""/>
                    <attribute id=""UUID"" type=""guid"" value=""810b5510-6748-4c8e-bef0-d990880ed1dd""/>
                </node>
                <node id=""ExperienceReward"">
                    <attribute id=""Level1"" type=""uint32"" value=""15""/>
                    <attribute id=""Level10"" type=""uint32"" value=""400""/>
                    <attribute id=""Level11"" type=""uint32"" value=""510""/>
                    <attribute id=""Level12"" type=""uint32"" value=""640""/>
                    <attribute id=""Level2"" type=""uint32"" value=""25""/>
                    <attribute id=""Level3"" type=""uint32"" value=""40""/>
                    <attribute id=""Level4"" type=""uint32"" value=""75""/>
                    <attribute id=""Level5"" type=""uint32"" value=""90""/>
                    <attribute id=""Level6"" type=""uint32"" value=""150""/>
                    <attribute id=""Level7"" type=""uint32"" value=""180""/>
                    <attribute id=""Level8"" type=""uint32"" value=""220""/>
                    <attribute id=""Level9"" type=""uint32"" value=""315""/>
                    <attribute id=""LevelSource"" type=""uint8"" value=""1""/>
                    <attribute id=""Name"" type=""FixedString"" value=""Elite""/>
                    <attribute id=""RewardType"" type=""uint8"" value=""0""/>
                    <attribute id=""UUID"" type=""guid"" value=""4ee02692-eb98-43a6-803f-2da645364568""/>
                </node>
                <node id=""ExperienceReward"">
                    <attribute id=""Level1"" type=""uint32"" value=""20""/>
                    <attribute id=""Level10"" type=""uint32"" value=""640""/>
                    <attribute id=""Level11"" type=""uint32"" value=""800""/>
                    <attribute id=""Level12"" type=""uint32"" value=""1000""/>
                    <attribute id=""Level2"" type=""uint32"" value=""40""/>
                    <attribute id=""Level3"" type=""uint32"" value=""50""/>
                    <attribute id=""Level4"" type=""uint32"" value=""100""/>
                    <attribute id=""Level5"" type=""uint32"" value=""150""/>
                    <attribute id=""Level6"" type=""uint32"" value=""230""/>
                    <attribute id=""Level7"" type=""uint32"" value=""280""/>
                    <attribute id=""Level8"" type=""uint32"" value=""350""/>
                    <attribute id=""Level9"" type=""uint32"" value=""500""/>
                    <attribute id=""LevelSource"" type=""uint8"" value=""1""/>
                    <attribute id=""Name"" type=""FixedString"" value=""Miniboss""/>
                    <attribute id=""RewardType"" type=""uint8"" value=""0""/>
                    <attribute id=""UUID"" type=""guid"" value=""206b753f-bc3b-46af-98b9-0c711d98c678""/>
                </node>
                <node id=""ExperienceReward"">
                    <attribute id=""Level1"" type=""uint32"" value=""30""/>
                    <attribute id=""Level10"" type=""uint32"" value=""875""/>
                    <attribute id=""Level11"" type=""uint32"" value=""1120""/>
                    <attribute id=""Level12"" type=""uint32"" value=""1400""/>
                    <attribute id=""Level2"" type=""uint32"" value=""75""/>
                    <attribute id=""Level3"" type=""uint32"" value=""100""/>
                    <attribute id=""Level4"" type=""uint32"" value=""150""/>
                    <attribute id=""Level5"" type=""uint32"" value=""250""/>
                    <attribute id=""Level6"" type=""uint32"" value=""320""/>
                    <attribute id=""Level7"" type=""uint32"" value=""400""/>
                    <attribute id=""Level8"" type=""uint32"" value=""500""/>
                    <attribute id=""Level9"" type=""uint32"" value=""700""/>
                    <attribute id=""LevelSource"" type=""uint8"" value=""1""/>
                    <attribute id=""Name"" type=""FixedString"" value=""Boss""/>
                    <attribute id=""RewardType"" type=""uint8"" value=""0""/>
                    <attribute id=""UUID"" type=""guid"" value=""484393d9-eb7b-4b3b-b69b-5fdbfa940403""/>
                </node>
                <node id=""ExperienceReward"">
                    <attribute id=""Level1"" type=""uint32"" value=""5""/>
                    <attribute id=""Level10"" type=""uint32"" value=""110""/>
                    <attribute id=""Level11"" type=""uint32"" value=""140""/>
                    <attribute id=""Level12"" type=""uint32"" value=""175""/>
                    <attribute id=""Level2"" type=""uint32"" value=""10""/>
                    <attribute id=""Level3"" type=""uint32"" value=""15""/>
                    <attribute id=""Level4"" type=""uint32"" value=""25""/>
                    <attribute id=""Level5"" type=""uint32"" value=""35""/>
                    <attribute id=""Level6"" type=""uint32"" value=""40""/>
                    <attribute id=""Level7"" type=""uint32"" value=""50""/>
                    <attribute id=""Level8"" type=""uint32"" value=""65""/>
                    <attribute id=""Level9"" type=""uint32"" value=""90""/>
                    <attribute id=""Name"" type=""FixedString"" value=""CloseBoosterEasy""/>
                    <attribute id=""RewardType"" type=""uint8"" value=""2""/>
                    <attribute id=""UUID"" type=""guid"" value=""ce7f8aea-6f9a-49b8-a3dd-7fb12d2eb745""/>
                </node>
                <node id=""ExperienceReward"">
                    <attribute id=""Level1"" type=""uint32"" value=""5""/>
                    <attribute id=""Level10"" type=""uint32"" value=""75""/>
                    <attribute id=""Level11"" type=""uint32"" value=""85""/>
                    <attribute id=""Level12"" type=""uint32"" value=""95""/>
                    <attribute id=""Level2"" type=""uint32"" value=""10""/>
                    <attribute id=""Level3"" type=""uint32"" value=""15""/>
                    <attribute id=""Level4"" type=""uint32"" value=""20""/>
                    <attribute id=""Level5"" type=""uint32"" value=""30""/>
                    <attribute id=""Level6"" type=""uint32"" value=""35""/>
                    <attribute id=""Level7"" type=""uint32"" value=""45""/>
                    <attribute id=""Level8"" type=""uint32"" value=""55""/>
                    <attribute id=""Level9"" type=""uint32"" value=""65""/>
                    <attribute id=""Name"" type=""FixedString"" value=""ProgressBooster""/>
                    <attribute id=""RewardType"" type=""uint8"" value=""2""/>
                    <attribute id=""UUID"" type=""guid"" value=""bbac01c1-eddd-416a-837b-317944d09413""/>
                </node>
                <node id=""ExperienceReward"">
                    <attribute id=""Level1"" type=""uint32"" value=""5""/>
                    <attribute id=""Level10"" type=""uint32"" value=""250""/>
                    <attribute id=""Level11"" type=""uint32"" value=""320""/>
                    <attribute id=""Level12"" type=""uint32"" value=""400""/>
                    <attribute id=""Level2"" type=""uint32"" value=""15""/>
                    <attribute id=""Level3"" type=""uint32"" value=""35""/>
                    <attribute id=""Level4"" type=""uint32"" value=""50""/>
                    <attribute id=""Level5"" type=""uint32"" value=""80""/>
                    <attribute id=""Level6"" type=""uint32"" value=""95""/>
                    <attribute id=""Level7"" type=""uint32"" value=""115""/>
                    <attribute id=""Level8"" type=""uint32"" value=""145""/>
                    <attribute id=""Level9"" type=""uint32"" value=""200""/>
                    <attribute id=""Name"" type=""FixedString"" value=""CloseBoosterHard""/>
                    <attribute id=""RewardType"" type=""uint8"" value=""2""/>
                    <attribute id=""UUID"" type=""guid"" value=""67439439-7cba-4077-81e8-3224086fc6f7""/>
                </node>
                <node id=""ExperienceReward"">
                    <attribute id=""Level1"" type=""uint32"" value=""5""/>
                    <attribute id=""Level10"" type=""uint32"" value=""10""/>
                    <attribute id=""Level11"" type=""uint32"" value=""10""/>
                    <attribute id=""Level12"" type=""uint32"" value=""10""/>
                    <attribute id=""Level2"" type=""uint32"" value=""5""/>
                    <attribute id=""Level3"" type=""uint32"" value=""5""/>
                    <attribute id=""Level4"" type=""uint32"" value=""5""/>
                    <attribute id=""Level5"" type=""uint32"" value=""10""/>
                    <attribute id=""Level6"" type=""uint32"" value=""10""/>
                    <attribute id=""Level7"" type=""uint32"" value=""10""/>
                    <attribute id=""Level8"" type=""uint32"" value=""10""/>
                    <attribute id=""Level9"" type=""uint32"" value=""10""/>
                    <attribute id=""Name"" type=""FixedString"" value=""CombatcloseBooster""/>
                    <attribute id=""RewardType"" type=""uint8"" value=""2""/>
                    <attribute id=""UUID"" type=""guid"" value=""d28b13b0-e0c0-4b5c-b166-ff17e50322cf""/>
                </node>
                <node id=""ExperienceReward"">
                    <attribute id=""Level1"" type=""uint32"" value=""5""/>
                    <attribute id=""Level10"" type=""uint32"" value=""75""/>
                    <attribute id=""Level11"" type=""uint32"" value=""85""/>
                    <attribute id=""Level12"" type=""uint32"" value=""95""/>
                    <attribute id=""Level2"" type=""uint32"" value=""10""/>
                    <attribute id=""Level3"" type=""uint32"" value=""15""/>
                    <attribute id=""Level4"" type=""uint32"" value=""20""/>
                    <attribute id=""Level5"" type=""uint32"" value=""30""/>
                    <attribute id=""Level6"" type=""uint32"" value=""35""/>
                    <attribute id=""Level7"" type=""uint32"" value=""45""/>
                    <attribute id=""Level8"" type=""uint32"" value=""55""/>
                    <attribute id=""Level9"" type=""uint32"" value=""65""/>
                    <attribute id=""Name"" type=""FixedString"" value=""ProgressMajor""/>
                    <attribute id=""RewardType"" type=""uint8"" value=""2""/>
                    <attribute id=""UUID"" type=""guid"" value=""85e62526-1d6d-4efb-8897-c602e530e7bf""/>
                </node>
                <node id=""ExperienceReward"">
                    <attribute id=""Level1"" type=""uint32"" value=""20""/>
                    <attribute id=""Level10"" type=""uint32"" value=""400""/>
                    <attribute id=""Level11"" type=""uint32"" value=""500""/>
                    <attribute id=""Level12"" type=""uint32"" value=""640""/>
                    <attribute id=""Level2"" type=""uint32"" value=""30""/>
                    <attribute id=""Level3"" type=""uint32"" value=""45""/>
                    <attribute id=""Level4"" type=""uint32"" value=""60""/>
                    <attribute id=""Level5"" type=""uint32"" value=""120""/>
                    <attribute id=""Level6"" type=""uint32"" value=""145""/>
                    <attribute id=""Level7"" type=""uint32"" value=""175""/>
                    <attribute id=""Level8"" type=""uint32"" value=""225""/>
                    <attribute id=""Level9"" type=""uint32"" value=""320""/>
                    <attribute id=""Name"" type=""FixedString"" value=""CloseMajor""/>
                    <attribute id=""RewardType"" type=""uint8"" value=""2""/>
                    <attribute id=""UUID"" type=""guid"" value=""436a9e5d-2102-4048-964d-2055a295e73e""/>
                </node>
                <node id=""ExperienceReward"">
                    <attribute id=""Level1"" type=""uint32"" value=""5""/>
                    <attribute id=""Level10"" type=""uint32"" value=""45""/>
                    <attribute id=""Level11"" type=""uint32"" value=""50""/>
                    <attribute id=""Level12"" type=""uint32"" value=""60""/>
                    <attribute id=""Level2"" type=""uint32"" value=""10""/>
                    <attribute id=""Level3"" type=""uint32"" value=""10""/>
                    <attribute id=""Level4"" type=""uint32"" value=""10""/>
                    <attribute id=""Level5"" type=""uint32"" value=""20""/>
                    <attribute id=""Level6"" type=""uint32"" value=""25""/>
                    <attribute id=""Level7"" type=""uint32"" value=""30""/>
                    <attribute id=""Level8"" type=""uint32"" value=""35""/>
                    <attribute id=""Level9"" type=""uint32"" value=""40""/>
                    <attribute id=""Name"" type=""FixedString"" value=""CombatCloseMajor""/>
                    <attribute id=""RewardType"" type=""uint8"" value=""2""/>
                    <attribute id=""UUID"" type=""guid"" value=""fae81b0d-9561-41c4-b71a-883272cfd3da""/>
                </node>
                <node id=""ExperienceReward"">
                    <attribute id=""Level1"" type=""uint32"" value=""5""/>
                    <attribute id=""Level10"" type=""uint32"" value=""400""/>
                    <attribute id=""Level11"" type=""uint32"" value=""500""/>
                    <attribute id=""Level12"" type=""uint32"" value=""640""/>
                    <attribute id=""Level2"" type=""uint32"" value=""10""/>
                    <attribute id=""Level3"" type=""uint32"" value=""30""/>
                    <attribute id=""Level4"" type=""uint32"" value=""60""/>
                    <attribute id=""Level5"" type=""uint32"" value=""120""/>
                    <attribute id=""Level6"" type=""uint32"" value=""145""/>
                    <attribute id=""Level7"" type=""uint32"" value=""175""/>
                    <attribute id=""Level8"" type=""uint32"" value=""225""/>
                    <attribute id=""Level9"" type=""uint32"" value=""320""/>
                    <attribute id=""Name"" type=""FixedString"" value=""ProgressMain""/>
                    <attribute id=""RewardType"" type=""uint8"" value=""2""/>
                    <attribute id=""UUID"" type=""guid"" value=""0ccb6004-47e8-4356-9299-2f69fdfcb13d""/>
                </node>
                <node id=""ExperienceReward"">
                    <attribute id=""Level1"" type=""uint32"" value=""50""/>
                    <attribute id=""Level10"" type=""uint32"" value=""650""/>
                    <attribute id=""Level11"" type=""uint32"" value=""840""/>
                    <attribute id=""Level12"" type=""uint32"" value=""1000""/>
                    <attribute id=""Level2"" type=""uint32"" value=""50""/>
                    <attribute id=""Level3"" type=""uint32"" value=""75""/>
                    <attribute id=""Level4"" type=""uint32"" value=""100""/>
                    <attribute id=""Level5"" type=""uint32"" value=""200""/>
                    <attribute id=""Level6"" type=""uint32"" value=""240""/>
                    <attribute id=""Level7"" type=""uint32"" value=""290""/>
                    <attribute id=""Level8"" type=""uint32"" value=""360""/>
                    <attribute id=""Level9"" type=""uint32"" value=""525""/>
                    <attribute id=""Name"" type=""FixedString"" value=""CloseMain""/>
                    <attribute id=""RewardType"" type=""uint8"" value=""2""/>
                    <attribute id=""UUID"" type=""guid"" value=""572cc0bc-ecf3-4a85-84be-10bdd2d60f3b""/>
                </node>
                <node id=""ExperienceReward"">
                    <attribute id=""Level1"" type=""uint32"" value=""15""/>
                    <attribute id=""Level10"" type=""uint32"" value=""200""/>
                    <attribute id=""Level11"" type=""uint32"" value=""250""/>
                    <attribute id=""Level12"" type=""uint32"" value=""300""/>
                    <attribute id=""Level2"" type=""uint32"" value=""30""/>
                    <attribute id=""Level3"" type=""uint32"" value=""30""/>
                    <attribute id=""Level4"" type=""uint32"" value=""30""/>
                    <attribute id=""Level5"" type=""uint32"" value=""60""/>
                    <attribute id=""Level6"" type=""uint32"" value=""70""/>
                    <attribute id=""Level7"" type=""uint32"" value=""80""/>
                    <attribute id=""Level8"" type=""uint32"" value=""110""/>
                    <attribute id=""Level9"" type=""uint32"" value=""160""/>
                    <attribute id=""Name"" type=""FixedString"" value=""CombatcloseMain""/>
                    <attribute id=""RewardType"" type=""uint8"" value=""2""/>
                    <attribute id=""UUID"" type=""guid"" value=""7aa9ef5d-b431-4a94-85d9-a68d915d3b64""/>
                </node>
                <node id=""ExperienceReward"">
                    <attribute id=""Level1"" type=""uint32"" value=""30""/>
                    <attribute id=""Level10"" type=""uint32"" value=""400""/>
                    <attribute id=""Level11"" type=""uint32"" value=""500""/>
                    <attribute id=""Level12"" type=""uint32"" value=""640""/>
                    <attribute id=""Level2"" type=""uint32"" value=""50""/>
                    <attribute id=""Level3"" type=""uint32"" value=""70""/>
                    <attribute id=""Level4"" type=""uint32"" value=""100""/>
                    <attribute id=""Level5"" type=""uint32"" value=""200""/>
                    <attribute id=""Level6"" type=""uint32"" value=""240""/>
                    <attribute id=""Level7"" type=""uint32"" value=""290""/>
                    <attribute id=""Level8"" type=""uint32"" value=""360""/>
                    <attribute id=""Level9"" type=""uint32"" value=""525""/>
                    <attribute id=""Name"" type=""FixedString"" value=""BypassedCombatMedium""/>
                    <attribute id=""RewardType"" type=""uint8"" value=""2""/>
                    <attribute id=""UUID"" type=""guid"" value=""86b0c895-49cd-4152-9b1e-dc2acd224025""/>
                </node>
                <node id=""ExperienceReward"">
                    <attribute id=""Level1"" type=""uint32"" value=""5""/>
                    <attribute id=""Level10"" type=""uint32"" value=""260""/>
                    <attribute id=""Level11"" type=""uint32"" value=""330""/>
                    <attribute id=""Level12"" type=""uint32"" value=""420""/>
                    <attribute id=""Level2"" type=""uint32"" value=""10""/>
                    <attribute id=""Level3"" type=""uint32"" value=""30""/>
                    <attribute id=""Level4"" type=""uint32"" value=""40""/>
                    <attribute id=""Level5"" type=""uint32"" value=""80""/>
                    <attribute id=""Level6"" type=""uint32"" value=""95""/>
                    <attribute id=""Level7"" type=""uint32"" value=""115""/>
                    <attribute id=""Level8"" type=""uint32"" value=""150""/>
                    <attribute id=""Level9"" type=""uint32"" value=""210""/>
                    <attribute id=""Name"" type=""FixedString"" value=""Small""/>
                    <attribute id=""RewardType"" type=""uint8"" value=""1""/>
                    <attribute id=""UUID"" type=""guid"" value=""4c4c1c60-3362-4e84-84ad-ae1a140b17ee""/>
                </node>
                <node id=""ExperienceReward"">
                    <attribute id=""Level1"" type=""uint32"" value=""10""/>
                    <attribute id=""Level10"" type=""uint32"" value=""500""/>
                    <attribute id=""Level11"" type=""uint32"" value=""630""/>
                    <attribute id=""Level12"" type=""uint32"" value=""780""/>
                    <attribute id=""Level2"" type=""uint32"" value=""20""/>
                    <attribute id=""Level3"" type=""uint32"" value=""60""/>
                    <attribute id=""Level4"" type=""uint32"" value=""75""/>
                    <attribute id=""Level5"" type=""uint32"" value=""150""/>
                    <attribute id=""Level6"" type=""uint32"" value=""180""/>
                    <attribute id=""Level7"" type=""uint32"" value=""210""/>
                    <attribute id=""Level8"" type=""uint32"" value=""275""/>
                    <attribute id=""Level9"" type=""uint32"" value=""400""/>
                    <attribute id=""Name"" type=""FixedString"" value=""Medium""/>
                    <attribute id=""RewardType"" type=""uint8"" value=""1""/>
                    <attribute id=""UUID"" type=""guid"" value=""be4218ef-3a29-4fbf-911a-255ee71d2b35""/>
                </node>
                <node id=""ExperienceReward"">
                    <attribute id=""Level1"" type=""uint32"" value=""15""/>
                    <attribute id=""Level10"" type=""uint32"" value=""660""/>
                    <attribute id=""Level11"" type=""uint32"" value=""850""/>
                    <attribute id=""Level12"" type=""uint32"" value=""1000""/>
                    <attribute id=""Level2"" type=""uint32"" value=""30""/>
                    <attribute id=""Level3"" type=""uint32"" value=""90""/>
                    <attribute id=""Level4"" type=""uint32"" value=""120""/>
                    <attribute id=""Level5"" type=""uint32"" value=""240""/>
                    <attribute id=""Level6"" type=""uint32"" value=""280""/>
                    <attribute id=""Level7"" type=""uint32"" value=""300""/>
                    <attribute id=""Level8"" type=""uint32"" value=""370""/>
                    <attribute id=""Level9"" type=""uint32"" value=""530""/>
                    <attribute id=""Name"" type=""FixedString"" value=""Big""/>
                    <attribute id=""RewardType"" type=""uint8"" value=""1""/>
                    <attribute id=""UUID"" type=""guid"" value=""1e2436a8-309e-4c8f-b77a-a6b1e4889fd9""/>
                </node>
                <node id=""ExperienceReward"">
                    <attribute id=""Level1"" type=""uint32"" value=""100""/>
                    <attribute id=""Level10"" type=""uint32"" value=""2400""/>
                    <attribute id=""Level11"" type=""uint32"" value=""3400""/>
                    <attribute id=""Level12"" type=""uint32"" value=""5000""/>
                    <attribute id=""Level2"" type=""uint32"" value=""200""/>
                    <attribute id=""Level3"" type=""uint32"" value=""300""/>
                    <attribute id=""Level4"" type=""uint32"" value=""500""/>
                    <attribute id=""Level5"" type=""uint32"" value=""1000""/>
                    <attribute id=""Level6"" type=""uint32"" value=""1100""/>
                    <attribute id=""Level7"" type=""uint32"" value=""1200""/>
                    <attribute id=""Level8"" type=""uint32"" value=""1500""/>
                    <attribute id=""Level9"" type=""uint32"" value=""2000""/>
                    <attribute id=""Name"" type=""FixedString"" value=""LevelBoost""/>
                    <attribute id=""RewardType"" type=""uint8"" value=""1""/>
                    <attribute id=""UUID"" type=""guid"" value=""85d04f48-87c7-45e0-83c5-fdd5b11465df""/>
                </node>
                <node id=""ExperienceReward"">
                    <attribute id=""Level1"" type=""uint32"" value=""15""/>
                    <attribute id=""Level10"" type=""uint32"" value=""170""/>
                    <attribute id=""Level11"" type=""uint32"" value=""220""/>
                    <attribute id=""Level12"" type=""uint32"" value=""275""/>
                    <attribute id=""Level2"" type=""uint32"" value=""20""/>
                    <attribute id=""Level3"" type=""uint32"" value=""25""/>
                    <attribute id=""Level4"" type=""uint32"" value=""30""/>
                    <attribute id=""Level5"" type=""uint32"" value=""50""/>
                    <attribute id=""Level6"" type=""uint32"" value=""60""/>
                    <attribute id=""Level7"" type=""uint32"" value=""75""/>
                    <attribute id=""Level8"" type=""uint32"" value=""95""/>
                    <attribute id=""Level9"" type=""uint32"" value=""135""/>
                    <attribute id=""Name"" type=""FixedString"" value=""BackgroundGoal""/>
                    <attribute id=""RewardType"" type=""uint8"" value=""2""/>
                    <attribute id=""UUID"" type=""guid"" value=""90f636c0-2d85-46d8-9760-30b57c664f4b""/>
                </node>
                <node id=""ExperienceReward"">
                    <attribute id=""Level1"" type=""uint32"" value=""30""/>
                    <attribute id=""Level2"" type=""uint32"" value=""30""/>
                    <attribute id=""Level3"" type=""uint32"" value=""30""/>
                    <attribute id=""Level4"" type=""uint32"" value=""30""/>
                    <attribute id=""Level5"" type=""uint32"" value=""30""/>
                    <attribute id=""Level6"" type=""uint32"" value=""30""/>
                    <attribute id=""Name"" type=""FixedString"" value=""RecruitCompanion""/>
                    <attribute id=""RewardType"" type=""uint8"" value=""2""/>
                    <attribute id=""UUID"" type=""guid"" value=""32b161e3-2f2d-4021-b3da-1ffc058e6e42""/>
                </node>
                <node id=""ExperienceReward"">
                    <attribute id=""Level1"" type=""uint32"" value=""30""/>
                    <attribute id=""Level2"" type=""uint32"" value=""30""/>
                    <attribute id=""Level3"" type=""uint32"" value=""30""/>
                    <attribute id=""Level4"" type=""uint32"" value=""30""/>
                    <attribute id=""Level5"" type=""uint32"" value=""30""/>
                    <attribute id=""Level6"" type=""uint32"" value=""30""/>
                    <attribute id=""Name"" type=""FixedString"" value=""RecruitCompanion_Shadowheart""/>
                    <attribute id=""RewardType"" type=""uint8"" value=""2""/>
                    <attribute id=""UUID"" type=""guid"" value=""1b6300aa-82a9-4acc-beaa-f3c3705680c4""/>
                </node>
                <node id=""ExperienceReward"">
                    <attribute id=""Level1"" type=""uint32"" value=""155""/>
                    <attribute id=""Level10"" type=""uint32"" value=""270""/>
                    <attribute id=""Level2"" type=""uint32"" value=""155""/>
                    <attribute id=""Level3"" type=""uint32"" value=""155""/>
                    <attribute id=""Level4"" type=""uint32"" value=""155""/>
                    <attribute id=""Level5"" type=""uint32"" value=""155""/>
                    <attribute id=""Level6"" type=""uint32"" value=""155""/>
                    <attribute id=""Level9"" type=""uint32"" value=""270""/>
                    <attribute id=""Name"" type=""FixedString"" value=""CRA_TempTUTExpReplacer""/>
                    <attribute id=""RewardType"" type=""uint8"" value=""1""/>
                    <attribute id=""UUID"" type=""guid"" value=""e3a83ddc-d5fe-493a-9947-9a8a3dd22b3c""/>
                </node>
                <node id=""ExperienceReward"">
                    <attribute id=""Level1"" type=""uint32"" value=""35""/>
                    <attribute id=""Level10"" type=""uint32"" value=""35""/>
                    <attribute id=""Level2"" type=""uint32"" value=""35""/>
                    <attribute id=""Level3"" type=""uint32"" value=""35""/>
                    <attribute id=""Level4"" type=""uint32"" value=""35""/>
                    <attribute id=""Level5"" type=""uint32"" value=""35""/>
                    <attribute id=""Level6"" type=""uint32"" value=""35""/>
                    <attribute id=""Level7"" type=""uint32"" value=""35""/>
                    <attribute id=""Level8"" type=""uint32"" value=""35""/>
                    <attribute id=""Level9"" type=""uint32"" value=""35""/>
                    <attribute id=""Name"" type=""FixedString"" value=""CRA_Escape_Mindlfayer""/>
                    <attribute id=""RewardType"" type=""uint8"" value=""0""/>
                    <attribute id=""UUID"" type=""guid"" value=""cd0bb362-7243-46da-83ac-2e65a67d6a27""/>
                </node>
            </children>
        </node>
    </region>
</save>
";

        public XPRewardsData() {
            InitDocument();
            GenerateData();
        }

        void GenerateData() {
            var nodes = XDocument
                .Element("save")
                .Element("region")
                .Element("node")
                .Element("children")
                .Elements("node")
                .Select(x => new XPRewardsDataNode() {
                    Name = x.Elements().Where(x => x.Attribute("id").Value == "Name").First().Attribute("value").Value,
                    UUID = x.Elements().Where(x => x.Attribute("id").Value == "UUID").First().Attribute("value").Value,
                    Records = new ObservableCollection<XPRewardsDataRecord>(x.Elements().Where(x => x.Attribute("id").Value.Contains("Level")).Select(x => new XPRewardsDataRecord() {
                        Name = x.Attribute("id").Value,
                        Value = int.Parse(x.Attribute("value").Value)
                    }))
                });

            XPRewardsDataRecords = new ObservableCollection<XPRewardsDataNode>(nodes);
        }

        void InitDocument() {
            XDocument = XDocument.Load(new StringReader(XP_REWARDS_BASE));
        }

        public XDocument XDocument { get; set; }

        public ObservableCollection<XPRewardsDataNode> XPRewardsDataRecords { get => GetValue<ObservableCollection<XPRewardsDataNode>>(); set => SetValue(value); }
    }
}
