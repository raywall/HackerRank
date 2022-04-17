

    static boolean isAnagram(String a, String b) {
        if (a.length() != b.length())
            return false;
        
        String
            lowerA = a.toLowerCase(),
            lowerB = b.toLowerCase();
            
        int[] itemsA = new int[256];
        int[] itemsB = new int[256];
            
        for (int i = 0; i < lowerA.length(); i++)
        {
            itemsA[(int) lowerA.charAt(i)]++;
            itemsB[(int) lowerB.charAt(i)]++;
        }
        
        for (int i = 0; i < itemsA.length; i++)
            if (itemsA[i] != itemsB[i])
                return false;
        
        return true;
    }

