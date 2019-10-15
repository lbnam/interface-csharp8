# interface-csharp8
<code>
 ICallable phone = new Android();
 
 phone.Call();
</code>

Result:<br/>
Calling..

<code>
(phone as IAndroidCallable).Call();

(phone as ICallable).Call();
</code>

Result:<br/>
Calling from AndroidCallable<br/>
Calling..

<code>
phone = new Ios();

phone.Call();
</code>

Result:<br/>
Calling IOS

<code>
(phone as IiPhoneCallable).Call();

(phone as ICallable).Call();   
</code>

Result:<br/>
<b>Calling IOS<br/>
Calling IOS<b/>
