
class ���[�O����Comparer : Comparer<TeamResult>
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

		int ret = �����_�����_���Ŕ���(x, y);
		if (ret != 0)
			return ret;

		count2++;

		ret = ���Y�`�[���̐��тŔ���(x, y);
		if (ret != 0)
			return ret;

		count3++;

		return ���I(x, y);
	}
}


 