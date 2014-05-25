class BookParser
  attr_reader :book

  def initialize(textfile)
    @book = File.read(textfile)
  end

  def split(string)
    string.gsub!(/[^\w\s]/, "")
    string.split(" ")
  end

  def occurences(string)
    counts = Hash.new 0
    string.each do |word|
      counts[word] += 1
    end
    counts
  end
end