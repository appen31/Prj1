class リーグ順位Comparer : Comparer<TeamResult>
{

	public override int Compare(TeamResult x, TeamResult y)
	{
		if (ReferenceEquals(x, y))
			return 0;
		else if (ReferenceEquals(x, null))
			return -1;
		else if (ReferenceEquals(y, null))
			return 1;

		int ret = 勝ち点得失点差で判定(x, y);
		if (ret != 0)
			return ret;

		count2++;

		ret = 当該チームの成績で判定(x, y);
		if (ret != 0)
			return ret;

		count3++;

		return 抽選(x, y);
	}
}

