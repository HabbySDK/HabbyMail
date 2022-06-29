using System;
using System.Collections;
using System.Collections.Generic;
using Habby.Tool;
using UnityEngine;
using UnityEngine.UI;

namespace  Habby.Mail
{
    public class SampleMail : MonoBehaviour
    {
        public Button list;
    
        public Button reward;
    
        public Button mark;
        public Button btnDelete;
        
        public Button gglist;
        
        public Button ggmark;
        public Button config;
    
        private void Awake()
        {
            list.onClick.AddListener(() =>
            {
                MailManager.GetMailList((reslist, msg, errorcode) =>
                {
                    if (errorcode == 0)
                    {
                        //TODO
                    }
                });
            });
            
            reward.onClick.AddListener(() =>
            {
                MailManager.GetMailReward(new string[]{"1234"},(response, msg, errorcode) =>
                {
                    if (errorcode == 0)
                    {
                        //TODO
                    }
                });
            });
            
            mark.onClick.AddListener(() =>
            {
                MailManager.MarkMailAsRead("1234",1,(response, msg, errorcode) =>
                {
                    if (errorcode == 0)
                    {
                        //TODO
                    }
                });
            });

            btnDelete?.onClick.AddListener(() =>
            {
                MailManager.DeleteMails(new string[1]{"1234"},(response, msg, errorcode) =>
                {
                    if (errorcode == 0)
                    {
                        //TODO
                    }
                });
            });

            
            gglist.onClick.AddListener(() =>
            {
                MailManager.GetAnnouncements(0,(response, msg, errorcode) =>
                {
                    if (errorcode == 0)
                    {
                        //TODO
                    }
                });
            });
            
            ggmark.onClick.AddListener(() =>
            {
                MailManager.MarkAnnouncementAsRead("1234",(response, msg, errorcode) =>
                {
                    if (errorcode == 0)
                    {
                        //TODO
                    }
                });
            });
            
            config.onClick.AddListener(() =>
            {
                MailManager.GetConfig((response, msg, errorcode) =>
                {
                    Debug.LogError(DataConvert.ToJson(response));
                    if (errorcode == 0)
                    {
                        //TODO
                    }
                });
            });
        }
    
        // Start is called before the first frame update
        void Start()
        {
            var tset = new MailSetting()
            {
                serverUrl = "https://test-mail.kinjarun.com",//mail server
                userId = "90005040",// userid mail used
                playerId = "90005040",//playerid  Announcement used
                appLanguage = "zh-CN",
                netVersion = "1",
                storeChannel = "AppStore"//AppStore/GooglePlay/OneStore/HuaWei/FacebookCloudGame
            };
            //init
            MailManager.Init(tset);
            
            //set customData
            MailManager.SetCustomField("usid","2是一种罪.");
            
            //set ex
            MailManager.Setting.appLanguage = "zh-CN"; 
            
            //set update event
            //every request
            //null or inited date
            MailManager.UpdateSettingDataEvent += () =>
            {
                return tset;
            };
        }
    
        // Update is called once per frame
        void Update()
        {
            
        }
    }

}
