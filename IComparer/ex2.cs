
class リーグ順位Comparer : Comparer<TeamResult>
{
	static int count1, count2, count3;

	public override int Compare(TeamResult x, TeamResult y)
	{
		if (x == y)
		{
			count0++;
			return 0;
		}

		count1++;

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


 