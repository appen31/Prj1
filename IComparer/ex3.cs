class [OΚComparer : Comparer<TeamResult>
{

	public override int Compare(TeamResult x, TeamResult y)
	{
		if (ReferenceEquals(x, y))
			return 0;
		else if (ReferenceEquals(x, null))
			return -1;
		else if (ReferenceEquals(y, null))
			return 1;

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

