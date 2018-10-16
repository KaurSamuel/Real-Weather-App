package md5c6a7e563005074e61b8f0765555a2388;


public class ForecastActivity
	extends android.support.v7.app.AppCompatActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Real_Weather_App.ForecastActivity, Real_Weather_App", ForecastActivity.class, __md_methods);
	}


	public ForecastActivity ()
	{
		super ();
		if (getClass () == ForecastActivity.class)
			mono.android.TypeManager.Activate ("Real_Weather_App.ForecastActivity, Real_Weather_App", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
