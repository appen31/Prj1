class ���[�O����Comparer : Comparer<TeamResult>
{

	public override int Compare(TeamResult x, TeamResult y)
	{
		if (ReferenceEquals(x, y))
			return 0;
		else if (ReferenceEquals(x, null))
			return -1;
		else if (ReferenceEquals(y, null))
			return 1;

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

