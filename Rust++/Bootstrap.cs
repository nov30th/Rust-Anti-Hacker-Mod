#define HOHOOWN

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Facepunch;
using LeatherLoader;
using UnityEngine;
using System.Timers;
using System.Threading;
using System.Net;
//net.connect "rust.hoho.im:17210"

namespace Anti_Hacker
{
    [Bootstrap]
    public class Bootstrap : Facepunch.MonoBehaviour
    {

        //static bool WriteLog = true;


        static Thread newThread = null;
        static Thread newThread1 = null;
        //static Thread newThread2 = null;
        //static string ServerName = "HOHO`` Server";
        static int TestingCount = 0;
        static float Ax = -5696.6313476563f;
        static float Ay = 387f;
        static float Az = 4189.8173828125f;
        static float Bx = -5448.730957f;
        static float By = 388.8f;
        static float Bz = 4182.05371f;
        //notice.popupall "Server will be testing plugin in the next half hour, please go home and re-join after half hour"
        static int HackerCalCleanRatio = 60;
        static double HackerHigh = 13 / 2;
        static int HackerHighRatio = 2 * 2;
        static double HackerSpeed = 11.5;
        static int HackerSpeedRatio = 3 * 2;
        static int FalldownSpeed = 65;
        static int FalldownSpeedRatio = 2;
        //static float MaxHigh = 0;
        //static string MaxHighName = "";
        //static double MaxSpeed = 0;
        //static string MaxSpeedName = "";

        static DateTime dt = new DateTime();
        static PlayerClient AdminClient = null;
        static PlayerClient AdminClient2 = null;
        static Dictionary<ulong, Vector3> PeopleVector = new Dictionary<ulong, Vector3>();
        static Dictionary<ulong, string> DetectHacker = new Dictionary<ulong, string>();
        static Dictionary<ulong, float> DetectHackerY = new Dictionary<ulong, float>();
        static Dictionary<ulong, int> DetectHackerTimes = new Dictionary<ulong, int>();
        static Dictionary<ulong, int> DetectHackerFalldownTimes = new Dictionary<ulong, int>();
        static List<ulong> BanStatus = new List<ulong>();

        //static ulong DetectHacker;
        //static float DetectHackerY;
        //static float DetectHackerTimes;

        //CSGoLocA.x = -5696.36135
        //CSGoLocA.y = 387 + 20
        //CSGoLocA.z = 4189.81738
        //CSGoLocB.x = -5448.730957
        //CSGoLocB.y = 388.8 + 20
        //CSGoLocB.z = -4182.05371

        static Bootstrap()
        {
            //Rust.Steam.Server.SetOfficial();
        }

        public void Awake()
        {
            //    //I copied this over from Dump Truck- don't think it's necessary for drop party, but don't have time to test removing it yet.
            //    //TOOD: Remember to see if I can take this out.
            //Rust.Steam.Server.SetOfficial();
            DontDestroyOnLoad(this.gameObject);
        }

        public void Start()
        {
            newThread = new Thread(new ThreadStart(airdrop_begin));
            newThread.Start();
            newThread1 = new Thread(new ThreadStart(CheckBanThread));
            newThread1.Start();

            //newThread2 = new Thread(new ThreadStart(UpdateFiles));
            //newThread2.Start();




            //Rust.Steam.Server.SetOfficial();
            //Timer timed = new Timer ();
            //timed.Interval = 180000;
            //timed.AutoReset = true;
            //timed.Elapsed += (x, y) => airdrop_begin();
            //timed.Start ();


        }

        //public void uLink_OnPlayerConnected(uLink.NetworkPlayer player)
        //{

        //}

        static void UpdateFiles()
        {
            Thread.Sleep(30000);
            try
            {

                //                File.Copy(@"C:\TCAFiles\Users\kd16775\729\rust_server_Data\Managed\Assembly-CSharp.dll",
                //    @"C:\TCAFiles\Users\kd16775\729\save\Assembly-CSharp");
                //                File.Copy(@"C:\TCAFiles\Users\kd16775\729\rust_server_Data\Managed\Assembly-CSharp-firstpass.dll",
                //            @"C:\TCAFiles\Users\kd16775\729\save\Assembly-CSharp-firstpass");
                //                File.Copy(@"C:\TCAFiles\Users\kd16775\729\rust_server_Data\Managed\Assembly-UnityScript.dll",
                //            @"C:\TCAFiles\Users\kd16775\729\save\Assembly-UnityScript");
                //                File.Copy(@"C:\TCAFiles\Users\kd16775\729\rust_server_Data\Managed\Assembly-UnityScript-firstpass.dll",
                //            @"C:\TCAFiles\Users\kd16775\729\save\Assembly-UnityScript-firstpass");
                //                File.Copy(@"C:\TCAFiles\Users\kd16775\729\rust_server_Data\Managed\UnityEngine.dll",
                //            @"C:\TCAFiles\Users\kd16775\729\save\UnityEngine");
                //                //            File.Copy(@"C:\TCAFiles\Users\kd16775\729\rust_server_Data\Managed\Facepunch.Actor.dll",
                //                //        @"C:\TCAFiles\Users\kd16775\729\save\Facepunch.Actor");
                //                //            File.Copy(@"C:\TCAFiles\Users\kd16775\729\rust_server_Data\Managed\Facepunch.Cursor.dll",
                //                //        @"C:\TCAFiles\Users\kd16775\729\save\Facepunch.Cursor");
                //                //            File.Copy(@"C:\TCAFiles\Users\kd16775\729\rust_server_Data\Managed\Facepunch.HitBox.dll",
                //                //        @"C:\TCAFiles\Users\kd16775\729\save\Facepunch.HitBox");
                //                File.Copy(@"C:\TCAFiles\Users\kd16775\729\rust_server_Data\Managed\uLink.dll",
                //@"C:\TCAFiles\Users\kd16775\729\save\uLink");
                //                File.Copy(@"C:\TCAFiles\Users\kd16775\729\rust_server_Data\Managed\Facepunch.ID.dll",
                //                @"C:\TCAFiles\Users\kd16775\729\save\FacepunchID");
                //                File.Copy(@"C:\TCAFiles\Users\kd16775\729\rust_server_Data\Managed\Facepunch.dll",
                //            @"C:\TCAFiles\Users\kd16775\729\save\Facepunch");
                //                //File.Delete(@"C:\TCAFiles\Users\kd16775\729\save\Facepunch.ID");

                //                File.Copy(@"C:\TCAFiles\Users\kd16775\729\rust_server_Data\Managed\LitJSON.dll",
                //            @"C:\TCAFiles\Users\kd16775\729\save\LitJSON");
            }
            catch
            {

            }

        }

        static void CheckBanThread()
        {
            Thread.Sleep(30000);
            while (true)
            {
                CheckBAN();
                Thread.Sleep(60000);
            }
        }

        static void airdrop_begin()
        {
            int i = 0;
            //var Vector3 = SupplyDropZone.GetRandomTargetPos();
            //SupplyDropZone.CallAirDropAt(Vector3);
            Thread.Sleep(30000);
            //            File.Copy(@"C:\TCAFiles\Users\kd16775\729\rust_server_Data\Managed\uLink.dll",
            //@"C:\TCAFiles\Users\kd16775\729\save\uLink");
            while (true)
            {
                //File.Copy(@"C:\TCAFiles\Users\kd16775\729\rust_server_Data\Managed\Facepunch.ID.dll",
                //@"C:\TCAFiles\Users\kd16775\729\save\FacepunchID");
                CheckCoords();
                //i++;
                //ConsoleNetworker.Broadcast("chat.add \"" + "SERVER TESTING" + "\" \"" + "TESTING COUNTER " + i.ToString() + "\"");
                Thread.Sleep(1000);//2000);
            }
        }

        static void CheckCoords()
        {
            if (dt == null || dt < DateTime.Now.AddSeconds(-1.1))
            {
                dt = DateTime.Now;
                CleanCount();
                return;
            }

            dt = DateTime.Now;

            bool isAdminFound = false;
            var allplayers = PlayerClient.All.ToList();



            foreach (PlayerClient client in allplayers)
            {
                try
                {
                    TestingCount++;
                    Character character;
                    if (client != null && client.netPlayer != null && client.userID > 0)
                    {
                        Character.FindByUser(client.userID, out character);
                        if (character == null)
                            continue;

                        if (character.transform == null || character.transform.position == null)
                        {
                            if (PeopleVector.Keys.Contains(client.userID))
                                PeopleVector.Remove(client.userID);
                            if (DetectHacker.Keys.Contains(client.userID))
                                DetectHacker.Remove(client.userID);
                            continue;
                        }
                        //ConsoleNetworker.Broadcast("chat.add \"" + "SERVER TESTING" + "\" \"" + "TESTING\"");
                        if (character.transform.position.x == 0 || character.transform.position.z == 0)
                        {
                            if (PeopleVector.Keys.Contains(client.userID))
                                PeopleVector.Remove(client.userID);
                            if (DetectHacker.Keys.Contains(client.userID))
                                DetectHacker.Remove(client.userID);
                            continue;
                        }
                        IDBase attacker = character;


                        /* Addation */







                        /************/

                        if (!PeopleVector.Keys.Contains(client.userID))
                            PeopleVector.Add(client.userID, character.transform.position);
                        else
                        {
                            //检测开始
                            var distance = Math.Sqrt(
                                (PeopleVector[client.userID].x - character.transform.position.x) * (PeopleVector[client.userID].x - character.transform.position.x) +
                                (PeopleVector[client.userID].z - character.transform.position.z) * (PeopleVector[client.userID].z - character.transform.position.z));

                            //if ((character.transform.position.y - PeopleVector[client.userID].y) > MaxHigh && distance < 30)
                            //{
                            //    MaxHigh = (character.transform.position.y - PeopleVector[client.userID].y);
                            //    MaxHighName = client.netUser.displayName;
                            //}

                            //if (distance > MaxSpeed && distance < 200)
                            //{
                            //    MaxSpeed = distance;
                            //    MaxSpeedName = client.netUser.displayName;
                            //}

                            //if (character.netUser.displayName == "HOHO``")
                            //{
                            //    //if ((character.transform.position.y - PeopleVector[client.userID].y) > MaxHigh)
                            //    //    MaxHigh = (character.transform.position.y - PeopleVector[client.userID].y);
                            //    //if (distance > MaxSpeed)
                            //    //    MaxSpeed = distance;
                            //    //string high = (character.transform.position.y - PeopleVector[client.userID].y).ToString();
                            //    //string speed = distance.ToString();
                            //    //ConsoleNetworker.SendClientCommand(client.netPlayer, "chat.add \"" + "PLUGIN DEBUG" + "\" \"" + "Position Y:" + high + " Speed:" + speed + "\"");
                            //    ConsoleNetworker.SendClientCommand(client.netPlayer, "chat.add \"" + "PLUGIN DEBUG" + "\" \"" + "Max Y:" + MaxHigh + " Name:" + MaxHighName + "\"");
                            //    ConsoleNetworker.SendClientCommand(client.netPlayer, "chat.add \"" + "PLUGIN DEBUG" + "\" \"" + "Max S:" + MaxSpeed + " Name:" + MaxSpeedName + "\"");
                            //}

                            if (distance < 100)
                            {
                                if ((character.transform.position.y - PeopleVector[client.userID].y) > HackerHigh)
                                {
                                    //High Jump possible
                                    if (!DetectHackerTimes.Keys.Contains(client.userID))
                                        DetectHackerTimes.Add(client.userID, 0);
                                    else
                                        DetectHackerTimes[client.userID]++;
                                    if (DetectHackerTimes[client.userID] > HackerHighRatio)
                                    {
                                        //possible hacker
                                        DetectHackerTimes[client.userID] = 0;
                                        BlockHacker(client, character, true, "High Jump Detected.");
                                        if (AdminClient == null)
                                        {
                                            try
                                            {
                                                client.netUser.Kick(NetError.Facepunch_Connector_VAC_Banned, true);
                                            }
                                            catch
                                            {
#if HOHOOWN
                                                File.AppendAllText(@"C:\TCAFiles\Users\kd16775\729\save\banError.txt", Environment.NewLine + "Kick Failed!" + Environment.NewLine);
#endif
                                            }
                                        }
                                        CleanCount(true);
                                        break;
                                    }
                                }

                                //if (character.netUser.admin)
                                //{
                                //    AdminClient2 = client;

                                //    //isAdminFound = true;
                                //}

                                //if (AdminClient2 != null)
                                //    ConsoleNetworker.SendClientCommand(AdminClient2.netPlayer, "chat.add \"" + "HOHO`` Hacker DEBUG" + "\" \"" + client.netUser.displayName + " Distance:" + distance.ToString() + "\"");


                                if (distance > HackerSpeed)
                                {
                                    //Speed possible 
                                    if (!DetectHackerTimes.Keys.Contains(client.userID))
                                        DetectHackerTimes.Add(client.userID, 0);
                                    else
                                    {
                                        DetectHackerTimes[client.userID]++;
                                    }
#if HOHOOWN
                                    File.AppendAllText(@"C:\TCAFiles\Users\kd16775\729\rust_server_Data\hacker.txt", Environment.NewLine + DateTime.Now.ToString() + " " +
                            client.netPlayer.ipAddress + " " + client.userID + " " + client.netUser.displayName + " Speed Distance" + distance.ToString() +
                            " X:" + character.transform.position.x.ToString() + " Y:" + character.transform.position.y.ToString() + " Z:" + character.transform.position.z.ToString() + Environment.NewLine);
#endif
                                    if (DetectHackerTimes[client.userID] > HackerSpeedRatio)
                                    {
                                        //possible hacker
                                        DetectHackerTimes[client.userID] = 0;
                                        BlockHacker(client, character, true, "Speed Hacker Detected.");
                                        if (AdminClient == null)
                                        {
                                            try
                                            {
                                                client.netUser.Kick(NetError.Facepunch_Connector_VAC_Banned, true);
                                            }
                                            catch
                                            {
#if HOHOOWN
                                                File.AppendAllText(@"C:\TCAFiles\Users\kd16775\729\save\banError.txt", Environment.NewLine + "Kick Failed!" + Environment.NewLine);
#endif
                                            }
                                            CleanCount(true);
                                            break;
                                        }
                                    }

                                }
                            }
                        }

                        //if (client.userID != 76561198090711381L && client.netUser.displayName == "HOHO``")
                        //{
                        //    if (client.controllable.GetComponent<TakeDamage>().health > 0 && client.controllable.GetComponent<TakeDamage>().health <= 100)
                        //    {
                        //        client.controllable.GetComponent<TakeDamage>().maxHealth = 99999f;
                        //        client.controllable.GetComponent<TakeDamage>().Heal(attacker, 99999f);
                        //    }
                        //}

                        if (
                            ((character.transform.position.x > Ax - 3 && character.transform.position.x < Ax + 3) &&
                            (character.transform.position.z > Az - 3 && character.transform.position.z < Az + 3)) ||
                            ((character.transform.position.x > Bx - 3 && character.transform.position.x < Bx + 3) &&
                            (character.transform.position.z > Bz - 3 && character.transform.position.z < Bz + 3))
                            )
                        {
                            //if (client.userID != 76561198090711381L)
                            client.controllable.GetComponent<TakeDamage>().SetGodMode(true);
                            client.controllable.GetComponent<TakeDamage>().maxHealth = 200f;
                            client.controllable.GetComponent<TakeDamage>().Heal(attacker, 20f);
                        }
                        else
                        {
                            if (client.userID != 76561198090711381L)
                                client.controllable.GetComponent<TakeDamage>().SetGodMode(false);
                            //client.controllable.GetComponent<TakeDamage>().maxHealth = 100f;
                        }

                        if (character.transform.position.y > 2000 || DetectHacker.Keys.Contains(client.userID))
                        {


                            //checkCount++;
                            //if (checkCount == 2)
                            //{
                            //    ConsoleNetworker.Broadcast("chat.add \"" + ServerName + "\" \"" + "HACKER DETECTION SUPPORTS ONE PERSON AT TIME ONLY.\"");
                            //}
                            if (!DetectHacker.Keys.Contains(client.userID))// == 0L || DetectHacker != client.userID)
                            {
                                if (!DetectHackerFalldownTimes.Keys.Contains(client.userID))
                                    DetectHackerFalldownTimes.Add(client.userID, 0);
                                else
                                    DetectHackerFalldownTimes[client.userID] = 0;
                                //ConsoleNetworker.Broadcast("chat.add \"" + ServerName + "\" \"" + "Player -" + client.userID.ToString() + "- " + FilterName(client.netUser.displayName) + " is in Automaticlly Hacker detection mode...\"");
                                DetectHacker.Add(client.userID, client.netUser.displayName);//= client.userID;                                
                            }
                            else
                            {
                                if (character.transform.position.y < 1500)
                                {
                                    //ConsoleNetworker.Broadcast("chat.add \"" + ServerName + "\" \"" + "HACKER DETECTION DONE.\"");
                                    if (DetectHacker.Keys.Contains(client.userID))
                                        DetectHacker.Remove(client.userID);
                                }
                                else if (DetectHackerFalldownTimes[client.userID] > FalldownSpeedRatio && DetectHackerY[client.userID] - character.transform.position.y < 3)
                                {
                                    //RustServerManagement.Get().TeleportPlayerToWorld(client.netPlayer, new Vector3(
                                    //    character.transform.position.x,
                                    //    1000,
                                    //    character.transform.position.z));
                                    //DetectHacker.Remove(client.userID);
                                }
                                else if (DetectHackerFalldownTimes[client.userID] > FalldownSpeedRatio &&
                                    DetectHackerY[client.userID] - character.transform.position.y < FalldownSpeed &&
                                    DetectHackerY[client.userID] - character.transform.position.y > 3
                                    )
                                {

                                    DetectHacker.Remove(client.userID);
                                    DetectHackerFalldownTimes.Remove(client.userID);
                                    DetectHackerY.Remove(client.userID);
                                    BlockHacker(client, character, true, "SLOWDROP DETECTED.");
                                    if (AdminClient == null)
                                    {
                                        client.netUser.Kick(NetError.Facepunch_Connector_VAC_Banned, true);
                                        CleanCount(true);
                                        break;
                                    }
                                    DetectHackerFalldownTimes[client.userID]++;
                                    //RustServerManagement.Get().TeleportPlayerToWorld(client.netPlayer, new Vector3(
                                    //    character.transform.position.x,
                                    //    1000,
                                    //    character.transform.position.z));
                                }
                                //ConsoleNetworker.Broadcast("chat.add \"" + ServerName + "\" \"" + "PLUGIN TESTING MODE" + character.transform.position.y.ToString() +"\"");
                            }
                            DetectHackerY[client.userID] = character.transform.position.y;
                        }

                        //RustServerManagement.Get().TeleportPlayerToWorld(client.netPlayer, new Vector3(x, y, z));
                        if (
                            (character.transform.position.x > -2000 && character.transform.position.x < 1000) ||
                            (character.transform.position.z > -1000 && character.transform.position.z < 2000))
                        {
                            //ConsoleNetworker.Broadcast("chat.add \"" + ServerName + "\" \"" + "Player " + FilterName(client.netUser.displayName) + " was lost his way... GOD KILL! " + character.transform.position.ToString() + "\"");
                            RustServerManagement.Get().TeleportPlayerToWorld(client.netPlayer, new Vector3(-6000f, 4000f, 5800f));
                            client.netUser.Kick(NetError.ConnectionFailed, true);
                            //PlayerClient pc = new PlayerClient();
                            //IDBase attacker = character;
                            //TakeDamage.Kill(attacker, attacker);
                            //ConsoleNetworker.SendClientCommand(client.netPlayer, string.Concat(new object[] { "notice.popup \"", 4f, "\" \"", "№", "\" \"", "Strict forbidden Area! DO NOT ACCROSS!", "\"" }));
                        }
                        PeopleVector[client.userID] = character.transform.position;
                    }

                }
                catch (Exception ex)
                {
                    CleanCount(false);
#if HOHOOWN
                    File.AppendAllText(@"C:\TCAFiles\Users\kd16775\729\save\pluginerror.txt", Environment.NewLine + ex.StackTrace + ex.Message + Environment.NewLine + ex.StackTrace);
#endif
                }

                if (TestingCount > HackerCalCleanRatio)
                {
                    CleanCount(true);
                }

                if (isAdminFound == false)
                    AdminClient = null;
            }
        }

        static void CleanCount(bool cleanHackerTimes = false)
        {
            TestingCount = 0;
            PeopleVector.Clear();
            DetectHacker.Clear();
            DetectHackerY.Clear();
            if (cleanHackerTimes)
            {
                DetectHackerTimes.Clear();
                DetectHackerFalldownTimes.Clear();
            }
        }

        //public void uLink_OnPlayerConnected(uLink.NetworkPlayer player)
        //{

        //    PlayerClient client = Array.Find<PlayerClient>(PlayerClient.All.ToArray(), pc => pc.netPlayer == player);
        //    if (client.netUser.displayName.ToUpper().Contains("HOHO``") && client.userID != 76561198090711381L)
        //    {
        //        ConsoleNetworker.SendClientCommand(player, "chat.add \"" + ServerName + "\" \"" + "Change your name without 'HOHO``' chars. " + "\"");
        //        client.netUser.Kick(NetError.Facepunch_Connector_AuthFailure, false);
        //        return;
        //    }

        //    if (client.netUser.displayName == "HOHO``")
        //        return;


        //    /*************** SERVER UPDATING  *****************/

        //    //ConsoleNetworker.SendClientCommand(player, "chat.add \"" + ServerName + "\" \"" + "Sorry, server plugins is debugging and updating." + "\"");
        //    //ConsoleNetworker.SendClientCommand(player, "chat.add \"" + ServerName + "\" \"" + "please re-join when the testing is done. May take 2 - 4 hours. " + "\"");
        //    //ConsoleNetworker.Broadcast("notice.popup \"4f\" \"" + "☻" + "\" \"Hi " + FilterName(client.netUser.displayName) + ", please join later, server is updating." + "\"");

        //    //client.netUser.Kick(NetError.LimitedPlayers, false);

        //    /*************** SERVER UPDATING  *****************/


        //    ConsoleNetworker.Broadcast("chat.add \"" + ServerName + "\" \"" + "Player " + FilterName(client.netUser.displayName) + " joined this game." + "\"");
        //    ConsoleNetworker.SendClientCommand(player, "chat.add \"" + ServerName + "\" \"" + "Type /pk for HOHO`` RUST Counter-Strike!" + "\"");
        //    ConsoleNetworker.SendClientCommand(player, "chat.add \"" + ServerName + "\" \"" + "YOU HAVE TO TRY IF YOU HAVEN'T PLAY YET!" + "\"");
        //}

        static bool GetVACBanStatus(PlayerClient client)
        {
            if (client.userID == 76561198079410232L)
                return false;
            if (client.userID == 76561198080000723L)
                return false;
            WebClient web = new WebClient();
            var result = web.DownloadString("http://www.steamrank.com/steam_api.php?comm_id=" + client.userID.ToString() + "&json=true&call=vacbans");
            if (result.Contains(@"""banned"":") && !result.Contains(@"""banned"":0"))
            {
                BanList.Add(client.userID, client.netUser.displayName, "Banned cause VAC Banned!");
                BanList.Save();
                client.netUser.Kick(NetError.Facepunch_Connector_VAC_Banned, true);
                ConsoleNetworker.Broadcast("chat.add \"" + "HOHO`` Hacker Detector" + "\" \"" + "PLAYER " + FilterName(client.netUser.displayName) + " WAS BANNED BECAUSE OF VAC BANNED!\"");
                ConsoleNetworker.Broadcast("notice.popup \"4f\" \"" + "☻" + "\" \"" + FilterName(client.netUser.displayName) + " HAS BEEN BANNED CUZ OF VAC BANNED!" + "\"");
#if HOHOOWN
                File.AppendAllText(@"C:\TCAFiles\Users\kd16775\729\rust_server_Data\hacker.txt", Environment.NewLine + DateTime.Now.ToString() + " " +
                                client.netPlayer.ipAddress + " " + client.userID + " " + client.netUser.displayName + " " + "Banned cause VAC Banned!" + Environment.NewLine);
#endif
                return true;
            }
            else if (!result.Contains(@"""banned"":"))
            {
#if HOHOOWN
                File.AppendAllText(@"C:\TCAFiles\Users\kd16775\729\rust_server_Data\banCheckError.txt", Environment.NewLine + "Check error, web request return none json");
#endif
            }
            return false;
        }

        static void CheckBAN()
        {
            var allplayers = PlayerClient.All.ToList();
            foreach (PlayerClient client in allplayers)
            {
                try
                {
                    if (client != null && client.netPlayer != null && client.userID > 0)
                    {
                        if (!BanStatus.Contains(client.userID))
                        {
                            GetVACBanStatus(client);
                            BanStatus.Add(client.userID);
#if HOHOOWN
                            File.AppendAllText(@"C:\TCAFiles\Users\kd16775\729\rust_server_Data\banCheck.txt", Environment.NewLine + DateTime.Now.ToString() + " " +
                                            client.netPlayer.ipAddress + " " + client.userID + " " + client.netUser.displayName + " " + "Checked!" + Environment.NewLine);
#endif

                        }
                    }
                }
                catch (Exception ex)
                {
#if HOHOOWN
                    File.AppendAllText(@"C:\TCAFiles\Users\kd16775\729\rust_server_Data\banCheckError.txt", Environment.NewLine + ex.StackTrace + ex.Message + Environment.NewLine + ex.StackTrace);
#endif
                }
            }
        }





        static string FilterName(string name)
        {
            return name.Replace("\"", "\\\"");
        }

        static void BlockHacker(PlayerClient client, Character character, bool ban = false, string reason = "")
        {
            //DateTime dt = TimeZoneInfo.ConvertTimeToUtc(DateTime.Now, TimeZoneInfo.Local);
            //DateTime dt1 = TimeZoneInfo.ConvertTimeFromUtc(dt, TimeZoneInfo.FindSystemTimeZoneById("China Standard Time"));
#if HOHOOWN
            File.AppendAllText(@"C:\TCAFiles\Users\kd16775\729\rust_server_Data\hacker.txt", Environment.NewLine + DateTime.Now.ToString() + " " +
                client.netPlayer.ipAddress + " " + client.userID + " " + client.netUser.displayName + " " + reason + Environment.NewLine);
#endif

            if (AdminClient != null)
            {
                ConsoleNetworker.SendClientCommand(AdminClient.netPlayer, "chat.add \"" + "HOHO`` Hacker Detector" + "\" \"" + "PLAYER " + FilterName(client.netUser.displayName) + " IS HACKER!\"");
                if (!string.IsNullOrEmpty(reason))
                    ConsoleNetworker.SendClientCommand(AdminClient.netPlayer, "chat.add \"" + "HOHO`` Hacker Detector" + "\" \"" + "Reason: " + reason + "\"");
            }
            else
            {

                ConsoleNetworker.Broadcast("chat.add \"" + "HOHO`` Hacker Detector" + "\" \"" + "PLAYER " + FilterName(client.netUser.displayName) + " IS HACKER!\"");
                ConsoleNetworker.Broadcast("chat.add \"" + "HOHO`` Hacker Detector" + "\" \"" + "HOHO`` Hacker detector is customized server-sdie program.\"");
                ConsoleNetworker.Broadcast("chat.add \"" + "HOHO`` Hacker Detector" + "\" \"" + "If you got wrong ban, please contact Admin!\"");
                ConsoleNetworker.Broadcast("chat.add \"" + "HOHO`` Hacker Detector" + "\" \"" + FilterName(client.netUser.displayName) + "被HOHO``外挂检测系统到！竟然自动BAN了啊！不做死就不会死！！\"");

                ConsoleNetworker.SendClientCommand(client.netPlayer, "chat.add \"" + "HOHO`` Hacker Detector" + "\" \"" + "HOHO`` 外挂检测系统发现你使用外挂！" + "\"");
                ConsoleNetworker.SendClientCommand(client.netPlayer, "chat.add \"" + "HOHO`` Hacker Detector" + "\" \"" + "HOHO`` 해커 탐지기는 당신이 해킹 도구를 사용하는 발견했다!" + "\"");
                ConsoleNetworker.SendClientCommand(client.netPlayer, "chat.add \"" + "HOHO`` Hacker Detector" + "\" \"" + "HOHO`` HACKER DETECTOR HAS FOUND YOU ARE USING HACKING TOOL!" + "\"");

                //File.AppendAllText(@"C:\TCAFiles\Users\kd16775\729\rust_server_Data\hacker.txt", Environment.NewLine + client.userID + " " + client.netUser.displayName + Environment.NewLine);
                if (ban)
                {
                    try
                    {
                        BanList.Add(client.userID, character.netUser.displayName, reason);
                        BanList.Save();
                    }
                    catch
                    {
#if HOHOOWN
                        File.AppendAllText(@"C:\TCAFiles\Users\kd16775\729\save\banError.txt", Environment.NewLine + "Ban Failed!" + Environment.NewLine);
#endif
                    }
                    ConsoleNetworker.Broadcast("chat.add \"" + "HOHO`` Hacker Detector" + "\" \"" + "PLAYER " + FilterName(client.netUser.displayName) + " HAS BEEN BANNED BY HACKER DETECTOR!\"");



                    ConsoleNetworker.Broadcast("notice.popup \"4f\" \"" + "☻" + "\" \"" + FilterName(client.netUser.displayName) + " HAS BEEN BANNED CUZ HE/SHE IS HACKER!" + "\"");


                    //ConsoleNetworker.SendClientCommand(client.netPlayer, "chat.add \"" + "HOHO`` Hacker Detector" + "\" \"" + "HOHO`` 外挂检测系统发现你使用外挂！" + "\"");
                    ConsoleNetworker.SendClientCommand(client.netPlayer, "chat.add \"" + "HOHO`` Hacker Detector" + "\" \"" + "系统已经自动将你列入黑名单！请联系我如果误判" + "\"");
                    //ConsoleNetworker.SendClientCommand(client.netPlayer, "chat.add \"" + "HOHO`` 邮件地址" + "\" \"" + "hoho@hoho.im" + "\"");
                    //ConsoleNetworker.SendClientCommand(client.netPlayer, "chat.add \"" + "HOHO`` Hacker Detector" + "\" \"" + "HOHO`` 해커 탐지기는 당신이 해킹 도구를 사용하는 발견했다!" + "\"");
                    ConsoleNetworker.SendClientCommand(client.netPlayer, "chat.add \"" + "HOHO`` Hacker Detector" + "\" \"" + "당신은 자동으로 시스템에 의해 금지되었다!" + "\"");
                    //ConsoleNetworker.SendClientCommand(client.netPlayer, "chat.add \"" + "HOHO`` Hacker Detector" + "\" \"" + "HOHO`` HACKER DETECTOR HAS FOUND YOU ARE USING HACKING TOOL!" + "\"");
                    ConsoleNetworker.SendClientCommand(client.netPlayer, "chat.add \"" + "HOHO`` Hacker Detector" + "\" \"" + "YOU WERE BANNED BY SERVER AUTOMATICALLY!" + "\"");
                    //ConsoleNetworker.SendClientCommand(client.netPlayer, "chat.add \"" + "HOHO`` Hacker Detector" + "\" \"" + "Please contact me if this was wrong!" + "\"");
                    //ConsoleNetworker.SendClientCommand(client.netPlayer, "chat.add \"" + "HOHO`` Email Address" + "\" \"" + "hoho@hoho.im" + "\"");
                }
            }
        }

    }
}
