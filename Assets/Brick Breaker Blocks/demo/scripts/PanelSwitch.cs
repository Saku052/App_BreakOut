using UnityEngine;

public class PanelSwitch : MonoBehaviour {

	[Header("canvas - panels")]
	public GameObject panel_01;
	public GameObject panel_02;
	public GameObject panel_03;
	public GameObject panel_04;
	public GameObject panel_05;
    public GameObject panel_06;
    public GameObject panel_07;

	[Header("canvas - panels - shadows")]
	public GameObject panel_shadows_a;
	public GameObject panel_shadows_b;
	public GameObject panel_shadows_c;
    public GameObject panel_shadows_d;
    public GameObject panel_shadows_e;

	[Header("canvas - buttons")]
	public GameObject panel_buttons_01;
	public GameObject panel_buttons_02;
	public GameObject panel_buttons_03;
	public GameObject panel_buttons_04;
	public GameObject panel_buttons_05;
    public GameObject panel_buttons_06;
    public GameObject panel_buttons_07;


	public void SwitchPanel_01 () {
		panel_01.SetActive(true);
		panel_02.SetActive(false);
		panel_03.SetActive(false);
		panel_04.SetActive(false);
		panel_05.SetActive(false);
        panel_06.SetActive(false);
        panel_07.SetActive(false);

		panel_shadows_a.SetActive(true);
		panel_shadows_b.SetActive(false);
		panel_shadows_c.SetActive(false);
        panel_shadows_d.SetActive(false);
        panel_shadows_e.SetActive(false);

		panel_buttons_01.SetActive(true);
		panel_buttons_02.SetActive(false);
		panel_buttons_03.SetActive(false);
		panel_buttons_04.SetActive(false);
		panel_buttons_05.SetActive(false);
        panel_buttons_06.SetActive(false);
        panel_buttons_07.SetActive(false);
	}

	public void SwitchPanel_02 () {
		panel_01.SetActive(false);
		panel_02.SetActive(true);
		panel_03.SetActive(false);
		panel_04.SetActive(false);
		panel_05.SetActive(false);
        panel_06.SetActive(false);
        panel_07.SetActive(false);

        panel_shadows_a.SetActive(false);
        panel_shadows_b.SetActive(true);
        panel_shadows_c.SetActive(false);
        panel_shadows_d.SetActive(false);
        panel_shadows_e.SetActive(false);

		panel_buttons_01.SetActive(false);
		panel_buttons_02.SetActive(true);
		panel_buttons_03.SetActive(false);
		panel_buttons_04.SetActive(false);
		panel_buttons_05.SetActive(false);
        panel_buttons_06.SetActive(false);
        panel_buttons_07.SetActive(false);
	}

	public void SwitchPanel_03 () {
		panel_01.SetActive(false);
		panel_02.SetActive(false);
		panel_03.SetActive(true);
		panel_04.SetActive(false);
		panel_05.SetActive(false);
        panel_06.SetActive(false);
        panel_07.SetActive(false);

        panel_shadows_a.SetActive(false);
        panel_shadows_b.SetActive(false);
        panel_shadows_c.SetActive(true);
        panel_shadows_d.SetActive(false);
        panel_shadows_e.SetActive(false);

		panel_buttons_01.SetActive(false);
		panel_buttons_02.SetActive(false);
		panel_buttons_03.SetActive(true);
		panel_buttons_04.SetActive(false);
		panel_buttons_05.SetActive(false);
        panel_buttons_06.SetActive(false);
        panel_buttons_07.SetActive(false);
	}

	public void SwitchPanel_04 () {
		panel_01.SetActive(false);
		panel_02.SetActive(false);
		panel_03.SetActive(false);
		panel_04.SetActive(true);
		panel_05.SetActive(false);
        panel_06.SetActive(false);
        panel_07.SetActive(false);

        panel_shadows_a.SetActive(false);
        panel_shadows_b.SetActive(false);
        panel_shadows_c.SetActive(true);
        panel_shadows_d.SetActive(false);
        panel_shadows_e.SetActive(false);

		panel_buttons_01.SetActive(false);
		panel_buttons_02.SetActive(false);
		panel_buttons_03.SetActive(false);
		panel_buttons_04.SetActive(true);
		panel_buttons_05.SetActive(false);
        panel_buttons_06.SetActive(false);
        panel_buttons_07.SetActive(false);
	}

	public void SwitchPanel_05 () {
		panel_01.SetActive(false);
		panel_02.SetActive(false);
		panel_03.SetActive(false);
		panel_04.SetActive(false);
		panel_05.SetActive(true);
        panel_06.SetActive(false);
        panel_07.SetActive(false);

		panel_shadows_a.SetActive(false);
		panel_shadows_b.SetActive(true);
		panel_shadows_c.SetActive(false);
        panel_shadows_d.SetActive(false);
        panel_shadows_e.SetActive(false);

		panel_buttons_01.SetActive(false);
		panel_buttons_02.SetActive(false);
		panel_buttons_03.SetActive(false);
		panel_buttons_04.SetActive(false);
		panel_buttons_05.SetActive(true);
        panel_buttons_06.SetActive(false);
        panel_buttons_07.SetActive(false);
	}

    public void SwitchPanel_06()
    {
        panel_01.SetActive(false);
        panel_02.SetActive(false);
        panel_03.SetActive(false);
        panel_04.SetActive(false);
        panel_05.SetActive(false);
        panel_06.SetActive(true);
        panel_07.SetActive(false);

        panel_shadows_a.SetActive(false);
        panel_shadows_b.SetActive(false);
        panel_shadows_c.SetActive(false);
        panel_shadows_d.SetActive(true);
        panel_shadows_e.SetActive(false);

        panel_buttons_01.SetActive(false);
        panel_buttons_02.SetActive(false);
        panel_buttons_03.SetActive(false);
        panel_buttons_04.SetActive(false);
        panel_buttons_05.SetActive(false);
        panel_buttons_06.SetActive(true);
        panel_buttons_07.SetActive(false);
    }

    public void SwitchPanel_07()
    {
        panel_01.SetActive(false);
        panel_02.SetActive(false);
        panel_03.SetActive(false);
        panel_04.SetActive(false);
        panel_05.SetActive(false);
        panel_06.SetActive(false);
        panel_07.SetActive(true);

        panel_shadows_a.SetActive(false);
        panel_shadows_b.SetActive(false);
        panel_shadows_c.SetActive(false);
        panel_shadows_d.SetActive(false);
        panel_shadows_e.SetActive(true);

        panel_buttons_01.SetActive(false);
        panel_buttons_02.SetActive(false);
        panel_buttons_03.SetActive(false);
        panel_buttons_04.SetActive(false);
        panel_buttons_05.SetActive(false);
        panel_buttons_06.SetActive(false);
        panel_buttons_07.SetActive(true);
    }
}
