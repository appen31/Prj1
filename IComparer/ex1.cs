class Main
{
	List<TeamResult> Teams;

	void Order()
	{
		Teams = Teams.OrderBy(r => r, new [OΚComparer()).ToList();
	}
}

class [OΚComparer : Comparer<TeamResult>
{
	static int count1, count2, count3;

	public override int Compare(TeamResult x, TeamResult y)
	{
		count1++;

		int ret = Ώ_ΎΈ_·Ε»θ(x, y);
		if (ret != 0)
			return ret;

		count2++;

		ret = Y`[Μ¬ΡΕ»θ(x, y);
		if (ret != 0)
			return ret;

		count3++;

		return I(x, y);
	}
}

