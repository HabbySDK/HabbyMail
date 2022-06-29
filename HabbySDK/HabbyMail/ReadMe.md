# Mail System


## Initialize

```c#
        using Habby.Mail;
        

        var tset = new MailSetting()
        {
            serverUrl = "https://test-mail-projecta.habby.com",//mail server
            userId = "90005040",// userid mail used
            playerId = "90005040",//playerid  Announcement used
            appLanguage = "zh-CN",// Language
            netVersion = "0", // If the version is not different, enter 0
            storeChannel = "AppStore" //AppStore/GooglePlay/OneStore/HuaWei/FacebookCloudGame
        };
    
        //init
        MailManager.Init(tset);
```

## API

- **Get Mails**

```c#
        MailManager.GetMailList((reslist, msg, errorcode) =>
        {
            if (errorcode == 0)
            {
                //TODO mail list
            }
        });
```

- **Get Rewards**

```c#
        MailManager.GetMailReward(new string[]{"1234"},(response, msg, errorcode) =>
        {
            if (errorcode == 0)
            {
                //TODO
            }
        });
```

- **Mark Mail**

```c#
        MailManager.MarkMailAsRead("1234",1,(response, msg, errorcode) =>
        {
            if (errorcode == 0)
            {
                //TODO mark
            }
        });
```

- **Delete mails**

```c#
        MailManager.DeleteMails(new string[1]{"1234"},(response, msg, errorcode) =>
        {
            if (errorcode == 0)
            {
                //TODO
            }
        });
```

- **Get Announcements**

```c#
        MailManager.GetAnnouncements(0,(response, msg, errorcode) =>
        {
            if (errorcode == 0)
            {
                //TODO
            }
        });
```

- **Mark Announcement Read**

```c#
        MailManager.MarkAnnouncementAsRead("1234",(response, msg, errorcode) =>
        {
            if (errorcode == 0)
            {
                //TODO
            }
        });
```

- **Get Maintenance Notice**

```c#
        MailManager.GetMaintenanceNotice((response,msg,erorcode)=>
        {
            if (errorcode == 0)
            {
                //TODO
            }
        });
```


## Change Setting

```c#
        //set ex
        MailManager.Setting.appLanguage = "zh-CN";
        
        // or
        
        //set update event
        //every request
        //null or inited date
        MailManager.UpdateSettingDataEvent += () =>
        {
            var tset = new MailSetting()
            return ret;
        };
```

## Example

> HabbySDK/HabbyMail/Example/sample.unity


## StatusCode

| Http Status Code | Status Code | Message | Description |
| --- | --- | --- | --- |
| 200 | 0 | Success | 成功 |
|  | 131001 | param error | 参数错误 |
| 200 | 131002 | user not found | 库里无此用户 |
|  | 131003 | userId and mailId not match | 不是此用户的邮件 |
|  | 131004 | not effective | 邮件未到生效时间 |
|  | 131005 | expired | 邮件已过期 |
|  | 131006 | already claimed | 邮件奖励已领取过 |
| 200 | 132001 | invalid giftcode | 无效的礼包码 |
|  | 132002 | already claimed | 礼包码已领取过 |
|  | 132003 | expired | 礼包码过期 |
|  | 132004 | not effective | 礼包码未生效 |
|  | 132005 | not matched | 不满足领取礼包码的条件 |
|  | 132006 | already bound | 此邮箱被人绑定过(礼包码) |
|  | 132007 | already claimed | 礼包码自己之前已经领取过 |
|  | 132008 | already bound | 自己已经绑过邮箱(礼包码) |
|  | 132009 | gift code campaign has ended | 礼包码活动已经领完了 |
| 200 | 139000 | server error | 服务器故障 |
| 200 | 139001 | server busy | 服务器繁忙 |
|  | 139002 | game server error | 游戏服故障 |